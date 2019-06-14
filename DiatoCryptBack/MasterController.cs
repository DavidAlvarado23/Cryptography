using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DiatoCryptBack
{
    public class MasterController
    {
        Master master;

        public MasterController()
        {
            master = new Master();
        }

        /**
         * Genera y guarda el par de claves.
         **/
        public KeyPair generateKeyPairRSA()
        {
            master.generateRSAKeys();
            return master.keys;
        }

        /**
         * Genera las llaves para el TDES.
         **/
        public string[] generateTDESKey()
        {
            master.generateTDESKey();

            return new string[3] { master.tdesKey1, master.tdesKey2, master.tdesKey3 };
        }

        /**
         * Lee un fichero del tipo xml. Si el 
         * formato es correcto lee la propiedad o 
         * la etiqueta con la clave publica compartida.
         **/
        public String importXMLWithPublicKey(String fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(fileName);

                    XmlNodeList elemList = xml.GetElementsByTagName("clavepublica");

                    master.saveSlavePublicKey(elemList[0].InnerText);
                    return master.getSlavePublicKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("El XML no es correcto: " + e.Message);
                    return "El fichero no es correcto";
                }
            }
            else
            {
                return "El fichero no es correcto";
            }
        }

        /**
         * Encripta las llaves TDES con la clave publica del esclavo.
         **/
        public string[] encryptTDESKeyWithSlavePublicKey()
        {
            return master.encryptTDESKeyWithSlavePublicKey();
        }

        /**
         * Exporta las llaves encriptadas del tdes con un cierto
         * formato. Este contiene las 3 claves encriptadas al igual
         * que el módulo encriptado.
         **/
        public bool exportXMLWithEncryptedTDES(String encryptedData, String encryptedData2, String encryptedData3)
        {
            if (encryptedData != null && encryptedData != "")
            {
                new XDocument(
                    new XElement("root",
                        new XElement("tdes1", encryptedData),
                        new XElement("tdes2", encryptedData2),
                        new XElement("tdes3", encryptedData3),
                        new XElement("iv", master.tdesIVEncrypted)
                    )
                ).Save("tdesencriptado.xml");

                return true;
            }
            return false;
        }

        /**
         * Importa el mensaje encriptado con un fichero
         * xml.
         **/
        public String importXMLMessage(String fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(fileName);

                    XmlNodeList elemList = xml.GetElementsByTagName("textoe");

                    return elemList[0].InnerText;
                }
                catch (Exception e)
                {
                    Console.WriteLine("El XML no es correcto: " + e.Message);
                    return "El fichero no es correcto";
                }
            }
            else
            {
                return "El fichero no es correcto";
            }
        }

        /**
         * Desencripta un mensaje dado.
         **/
        public String decryptText(String encryptedText)
        {
            return master.decryptText(encryptedText);
        }
    }
}
