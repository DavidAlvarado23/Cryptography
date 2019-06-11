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

        public KeyPair generateKeyPairRSA()
        {
            master.generateRSAKeys();
            return master.keys;
        }

        public string[] generateTDESKey()
        {
            master.generateTDESKey();

            return new string[3] { master.tdesKey1, master.tdesKey2, master.tdesKey3 };
        }

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

        public string[] encryptTDESKeyWithSlavePublicKey()
        {
            return master.encryptTDESKeyWithSlavePublicKey();
        }

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

        public String decryptText(String encryptedText)
        {
            return master.decryptText(encryptedText);
        }
    }
}
