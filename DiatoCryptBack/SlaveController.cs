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

        public KeyPair generateKeyPairRSA()
        {
            slave.generateRSAKeys();
            return slave.keys;
        }

        public bool exportXMLWithPublicKey()
        {
            if (slave.keys.publicKey != null)
            {
                slave.generatedSerializedKeys();

                new XDocument(
                    new XElement("clavepublica", slave.keys.serializedPublicKey)
                ).Save("cp_esclavo.xml");
                return true;
            }
            return false;
        }

        public String importTDESKeyInXML(String fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(fileName);

                    XmlNodeList elemList = xml.GetElementsByTagName("tdes1");
                    XmlNodeList elem = xml.GetElementsByTagName("tdes1iv");

                    slave.tdesIVMasterEncrypted = elem[0].InnerText;

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

        public String decryptTDESKey(String encryptedData)
        {
            return slave.decryptTDESKey(encryptedData);
        }

        public String encryptText(String text, String tdesKey)
        {
            return slave.encryptText(text, tdesKey);
        }

        public bool exportXMLWithEncryptedText(String encryptedText)
        {
            if (encryptedText != null)
            {
                new XDocument(
                    new XElement("Resultado_del_texto",
                        new XElement("textoe", encryptedText)
                    )
                ).Save("textoencriptado.xml");
                return true;
            }
            return false;
        }
    }
}
