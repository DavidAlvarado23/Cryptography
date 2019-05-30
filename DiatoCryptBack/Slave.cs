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

        public void generateRSAKeys()
        {
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);

            keys.publicKey = Convert.ToBase64String(RSAKeyInfo.Modulus);
            keys.privateKey = Convert.ToBase64String(RSAKeyInfo.D);
        }

        public void generatedSerializedKeys()
        {
            var sw = new StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            var pubKey = RSA.ExportParameters(false);
            xs.Serialize(sw, pubKey);
            keys.serializedPublicKey = sw.ToString();

            var privKey = RSA.ExportParameters(true);
            xs.Serialize(sw, privKey);
            keys.serializedPrivateKey = sw.ToString();
        }

        public String decryptTDESKey(String encryptedData)
        {
            if (encryptedData != null && !encryptedData.Equals(""))
            {
                try
                {
                    var bytesCypherText = Convert.FromBase64String(encryptedData);
                    RSA.ImportParameters(RSA.ExportParameters(true));

                    var bytesPlainTextData = RSA.Decrypt(bytesCypherText, false);

                    return Encoding.Unicode.GetString(bytesPlainTextData);
                }
                catch (Exception e)
                {
                    throw new Exception("No se pudo realizar la acción. Verifique que haya una clave correcta.");
                }
            }
            return null;
        }

        public String encryptText(String text, String tdesKey)
        {
            if (tdesKey != null && !tdesKey.Equals("") && text != null && !text.Equals(""))
            {
                TDES.Key = Convert.FromBase64String(tdesKey);

                byte[] iv = Encoding.Unicode.GetBytes(decryptTDESKey(tdesIVMasterEncrypted));

                TDES.IV = Convert.FromBase64String(Convert.ToBase64String(iv));

                ICryptoTransform encryptor = TDES.CreateEncryptor(TDES.Key, TDES.IV);

                MemoryStream ms = new MemoryStream();

                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                        sw.Write(text);
                    byte[] encrypted = ms.ToArray();

                    return Convert.ToBase64String(encrypted);
                }
            }
            return null;
        }
    }
}
