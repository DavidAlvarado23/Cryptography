using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace DiatoCryptBack
{
    /**
     * Clase Master que extiende de la clase abstracta AbstractUser.
     * Tiene un RSA para guardar la clave del esclavo que posteriormente
     * recibe. También, tiene 3 propiedades para guardas las diferentes 
     * llaves del TDES y su módulo. Las otras propiedades son las que 
     * contiene la clase abstracta.
     **/
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

        /**
         * Genera y guarda el par de claves.
         **/
        public void generateRSAKeys()
        {
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);

            keys.publicKey = Convert.ToBase64String(RSAKeyInfo.Modulus);
            keys.privateKey = Convert.ToBase64String(RSAKeyInfo.D);
        }

        /**
         * Genera las llaves para el TDES si no hay llaves.
         * Luego estas pasan a un string hexadecimal.
         */
        public void generateTDESKey()
        {
            if (tdesKey1 == null && tdesKey2 == null && tdesKey3 == null)
            {
                TDES.GenerateKey();
                TDES.GenerateIV();

                Console.WriteLine("Original Key: " + Convert.ToBase64String(TDES.Key));
                Console.WriteLine("Hex Key: " + BitConverter.ToString(TDES.Key).Replace("-", ""));

                tdesKey1 = BitConverter.ToString(TDES.Key.Take(8).ToArray()).Replace("-", "");
                tdesKey2 = BitConverter.ToString(TDES.Key.Skip(8).Take(8).ToArray()).Replace("-", "");
                tdesKey3 = BitConverter.ToString(TDES.Key.Skip(16).Take(8).ToArray()).Replace("-", "");
            }
        }

        /**
         * Guarda la llave del esclavo en su clase RSACryptoServiceProvider.
         * Lo hace gracias al import de un xml que esta clase tiene.
         **/
        public void saveSlavePublicKey(String serializedPublicKey)
        {

            if (slaveRSA == null)
            {
                slaveRSA = new RSACryptoServiceProvider();
            }

            slaveRSA.FromXmlString(serializedPublicKey);
        }

        /**
         * Devuelve la llave guardada del esclavo.
         **/
        public String getSlavePublicKey()
        {
            RSAParameters RSAKeyInfo = slaveRSA.ExportParameters(false);

            return Convert.ToBase64String(RSAKeyInfo.Modulus);
        }

        /**
         * Encripta las llaves TDES generadas con el algoritmo
         * RSA y con la llave pública del esclavo. Luego estas son 
         * convertidas a un string hexadecimal.
         **/
        public string[] encryptTDESKeyWithSlavePublicKey()
        {
            if (slaveRSA != null)
            {

                var ivEncrypted = slaveRSA.Encrypt(fromHexToByte(BitConverter.ToString(TDES.IV).Replace("-", "")), true);
                tdesIVEncrypted = BitConverter.ToString(ivEncrypted).Replace("-", "");

                byte[] tdesKey1Encrypted = slaveRSA.Encrypt(fromHexToByte(tdesKey1), true);
                byte[] tdesKey2Encrypted = slaveRSA.Encrypt(fromHexToByte(tdesKey2), true);
                byte[] tdesKey3Encrypted = slaveRSA.Encrypt(fromHexToByte(tdesKey3), true);

                return new string[3]
                {
                    BitConverter.ToString(tdesKey1Encrypted).Replace("-", ""),
                    BitConverter.ToString(tdesKey2Encrypted).Replace("-", ""),
                    BitConverter.ToString(tdesKey3Encrypted).Replace("-", "")
                };
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
         * Recibe un texto presuntamente encriptado, este
         * lo desencripta con su llave del TDES generada.
         **/
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
