using System;
using System.IO;
using System.Security.Cryptography;

namespace DiatoCryptBack
{
    public class Master : AbstractUser
    {
        RSACryptoServiceProvider slaveRSA;
        public String tdesKey { get; set; }
        public String tdesIVEncrypted { get; set; }

        public Master()
        {
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
            if (tdesKey == null)
            {
                TDES.GenerateKey();
                TDES.GenerateIV();
                tdesKey = Convert.ToBase64String(TDES.Key);
            }
        }

        public void saveSlavePublicKey(String serializedPublicKey)
        {
            var sr = new System.IO.StringReader(serializedPublicKey);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            RSAParameters publicKey = (RSAParameters)xs.Deserialize(sr);

            if (slaveRSA == null)
            {
                slaveRSA = new RSACryptoServiceProvider();
            }

            slaveRSA.ImportParameters(publicKey);
        }

        public String getSlavePublicKey()
        {
            RSAParameters RSAKeyInfo = slaveRSA.ExportParameters(false);

            return Convert.ToBase64String(RSAKeyInfo.Modulus);
        }

        public String encryptTDESKeyWithSlavePublicKey()
        {
            if (slaveRSA != null)
            {
                tdesIVEncrypted = Convert.ToBase64String(slaveRSA.Encrypt(TDES.IV, false));

                var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(tdesKey);
                return Convert.ToBase64String(slaveRSA.Encrypt(bytesPlainTextData, false));
            }
            return null;
        }

        public String decryptText(String encryptedText)
        {
            if (encryptedText != null && !encryptedText.Equals(""))
            {
                try
                {
                    var textInBytes = Convert.FromBase64String(encryptedText);

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
