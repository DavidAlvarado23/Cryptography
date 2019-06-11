using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace DiatoCryptBack
{
    public class Master : AbstractUser
    {
        RSACryptoServiceProvider slaveRSA;
        public String tdesKey1 { get; set; }
        public String tdesKey2 { get; set; }
        public String tdesKey3 { get; set; }
        public String tdesIVEncrypted { get; set; }

        public Master()
        {
            RSA.KeySize = 512;
            TDES = new TripleDESCryptoServiceProvider();
        }

        public void generateRSAKeys()
        {
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);

            keys.publicKey = Convert.ToBase64String(RSAKeyInfo.Modulus);
            keys.privateKey = Convert.ToBase64String(RSAKeyInfo.D);
        }

        public void generateTDESKey()
        {
            if (tdesKey1 == null && tdesKey2 == null && tdesKey3 == null)
            {
                TDES.GenerateKey();
                TDES.GenerateIV();

                Console.WriteLine("Original Key: " + Convert.ToBase64String(TDES.Key));

                tdesKey1 = BitConverter.ToString(TDES.Key.Take(8).ToArray()).Replace("-", "");
                tdesKey2 = BitConverter.ToString(TDES.Key.Skip(8).Take(8).ToArray()).Replace("-", "");
                tdesKey3 = BitConverter.ToString(TDES.Key.Skip(16).Take(8).ToArray()).Replace("-", "");
            }
        }

        public void saveSlavePublicKey(String serializedPublicKey)
        {

            if (slaveRSA == null)
            {
                slaveRSA = new RSACryptoServiceProvider();
            }

            slaveRSA.FromXmlString(serializedPublicKey);
        }

        public String getSlavePublicKey()
        {
            RSAParameters RSAKeyInfo = slaveRSA.ExportParameters(false);

            return Convert.ToBase64String(RSAKeyInfo.Modulus);
        }

        public string[] encryptTDESKeyWithSlavePublicKey()
        {
            if (slaveRSA != null)
            {

                var a = Convert.FromBase64String(BitConverter.ToString(TDES.IV).Replace("-", ""));
                var ivEncrypted = slaveRSA.Encrypt(a, false);
                tdesIVEncrypted = BitConverter.ToString(ivEncrypted).Replace("-", "");

                byte[] tdesKey1Encrypted = slaveRSA.Encrypt(Convert.FromBase64String(tdesKey1), false);
                byte[] tdesKey2Encrypted = slaveRSA.Encrypt(Convert.FromBase64String(tdesKey2), false);
                byte[] tdesKey3Encrypted = slaveRSA.Encrypt(Convert.FromBase64String(tdesKey3), false);

                return new string[3]
                {
                    BitConverter.ToString(tdesKey1Encrypted).Replace("-", ""),
                    BitConverter.ToString(tdesKey2Encrypted).Replace("-", ""),
                    BitConverter.ToString(tdesKey3Encrypted).Replace("-", "")
                };
            }
            return null;
        }

        private byte[] fromHexToByte(String hex)
        {
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
        }

        public String decryptText(String encryptedText)
        {
            if (encryptedText != null && !encryptedText.Equals(""))
            {
                try
                {
                    var textInBytes = fromHexToByte(encryptedText);

                    ICryptoTransform decryptor = TDES.CreateDecryptor(TDES.Key, TDES.IV);
                    using (MemoryStream ms = new MemoryStream(textInBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                return reader.ReadToEnd();
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception("No se pudo realizar la acción. Verifique que las claves sean las correctas");
                }
            }
            return encryptedText;
        }
    }
}
