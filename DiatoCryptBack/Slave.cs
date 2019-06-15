using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace DiatoCryptBack
{
    class Slave : AbstractUser
    {
        public String tdesIVMasterEncrypted { get; set; }

        public Slave()
        {
            RSA.KeySize = 512;
        }

        /**
         * Genera y guarda el par de claves.
         */
        public void generateRSAKeys()
        {
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);

            keys.publicKey = Convert.ToBase64String(RSAKeyInfo.Modulus);
            keys.privateKey = Convert.ToBase64String(RSAKeyInfo.D);
        }

        /**
         * Dadas las 3 llaves encriptadas, este las desencripta
         * con la llave privada y devuelve un array con estas
         * llaves desencriptadas.
         **/
        public string[] decryptTDESKey(String encryptedData, String encryptedData2, String encryptedData3)
        {
            if (encryptedData != null && !encryptedData.Equals(""))
            {
                try
                {
                    RSA.ImportParameters(RSA.ExportParameters(true));

                    var bytesPlainTextData = RSA.Decrypt(fromHexToByte(encryptedData), true);
                    var bytesPlainTextData2 = RSA.Decrypt(fromHexToByte(encryptedData2), true);
                    var bytesPlainTextData3 = RSA.Decrypt(fromHexToByte(encryptedData3), true);

                    return new string[3]
                    {
                        BitConverter.ToString(bytesPlainTextData).Replace("-", ""),
                         BitConverter.ToString(bytesPlainTextData2).Replace("-", ""),
                        BitConverter.ToString(bytesPlainTextData3).Replace("-", "")
                    };
                }
                catch (Exception e)
                {
                    throw new Exception("No se pudo realizar la acción. Verifique que haya una clave correcta.");
                }
            }
            return null;
        }

        /**
         * Método privado que nos convierte de string de hexadecimal
         * a un array de bytes.
         **/
        private byte[] fromHexToByte(String hex)
        {
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
        }

        /**
         * Con un texto dado, este lo encripta con la
         * llave generada del TDES que ha recibido anteriormente.
         **/
        public String encryptText(String text, String tdesKey1, String tdesKey2, String tdesKey3)
        {
            if (tdesKey1 != null && !tdesKey1.Equals("") && text != null && !text.Equals(""))
            {
                byte[] key1bytes = fromHexToByte(tdesKey1);
                byte[] key2bytes = fromHexToByte(tdesKey2);
                byte[] key3bytes = fromHexToByte(tdesKey3);

                var tdesKey = new byte[key1bytes.Length + key2bytes.Length + key3bytes.Length];
                key1bytes.CopyTo(tdesKey, 0);
                key2bytes.CopyTo(tdesKey, key1bytes.Length);
                key3bytes.CopyTo(tdesKey, key1bytes.Length + key2bytes.Length);

                TDES.Key = tdesKey;

                byte[] ivInHex = RSA.Decrypt(fromHexToByte(tdesIVMasterEncrypted), true);
                TDES.IV = ivInHex;

                ICryptoTransform encryptor = TDES.CreateEncryptor(TDES.Key, TDES.IV);

                MemoryStream ms = new MemoryStream();

                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                        sw.Write(text);
                    byte[] encrypted = ms.ToArray();

                    return BitConverter.ToString(encrypted).Replace("-", "");
                }
            }
            return null;
        }
    }
}
