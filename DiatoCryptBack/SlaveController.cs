using System;
using System.Xml;
using System.Xml.Linq;

namespace DiatoCryptBack
{
    public class SlaveController
    {
        Slave slave;

        public SlaveController()
        {
            slave = new Slave();
        }

        /**
         * Genera y guarda el par de claves.
         **/
        public KeyPair generateKeyPairRSA()
        {
            slave.generateRSAKeys();
            return slave.keys;
        }

        /**
         * Exporta la llave publica a un fichero xml.
         **/
        public bool exportXMLWithPublicKey()
        {
            if (slave.keys.publicKey != null)
            {
                new XDocument(
                    new XElement("root",
                        new XElement("clavepublica", slave.RSA.ToXmlString(false))
                    )
                ).Save("cp_esclavo.xml");
                return true;
            }
            return false;
        }

        /**
         * Importa con un fichero con una formato
         * que contiene 3 llaves o etiquetas junto con
         * el modulo, esto para generar una llave TDES.
         **/
        public string[] importTDESKeyInXML(String fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(fileName);

                    XmlNodeList elemList = xml.GetElementsByTagName("tdes1");
                    XmlNodeList elemList2 = xml.GetElementsByTagName("tdes2");
                    XmlNodeList elemList3 = xml.GetElementsByTagName("tdes3");
                    XmlNodeList elem = xml.GetElementsByTagName("iv");

                    slave.tdesIVMasterEncrypted = elem[0].InnerText;

                    return new string[3] { elemList[0].InnerText, elemList2[0].InnerText, elemList3[0].InnerText };
                }
                catch (Exception e)
                {
                    Console.WriteLine("El XML no es correcto: " + e.Message);
                }
            }
            return null;
        }

        /**
         * Desencripta las llaves dadas.
         **/
        public string[] decryptTDESKey(String encryptedData, String encryptedData2, String encryptedData3)
        {
            return slave.decryptTDESKey(encryptedData, encryptedData2, encryptedData3);
        }

        /**
         * Dado un texto lo encripta con el algoritmo
         * RSA.
         **/
        public String encryptText(String text, String tdesKey1, String tdesKey2, String tdesKey3)
        {
            return slave.encryptText(text, tdesKey1, tdesKey2, tdesKey3);
        }

        /**
         * Exporta el mensaje encriptado a un fichero xml.
         **/
        public bool exportXMLWithEncryptedText(String encryptedText)
        {
            if (encryptedText != null)
            {
                new XDocument(
                    new XElement("root",
                        new XElement("textoe", encryptedText)
                    )
                ).Save("textoencriptado.xml");
                return true;
            }
            return false;
        }
    }
}
