using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Xml;

using DiatoCryptBack;

namespace DiatoCript
{
    public partial class Form1 : Form
    {
        MasterController masterController;
        SlaveController slaveController;

        public Form1()
        {
            InitializeComponent();

            masterController = new MasterController();
            slaveController = new SlaveController();
        }

        private void generateTDESKeyButton_Click(object sender, EventArgs e)
        {
            masterTDESKeyLabel.Text = masterController.generateTDESKey();
        }

        private void generateRSAKeysMasterButton_Click(object sender, EventArgs e)
        {
            generateAllRSAKeys();
        }

        private void generateRSAKeysSlaveButton_Click(object sender, EventArgs e)
        {
            generateAllRSAKeys();
        }

        public void generateAllRSAKeys()
        {
            KeyPair masterKeys = masterController.generateKeyPairRSA();
            KeyPair slaveKeys = slaveController.generateKeyPairRSA();

            masterPrivateKeyLabel.Text = masterKeys.privateKey;
            masterPublicKeyLabel.Text = masterKeys.publicKey;

            slavePrivateKeyLabel.Text = slaveKeys.privateKey;
            slavePublicKeyLabel.Text = slaveKeys.publicKey;
        }

        private void importPublicKeyRSAButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = fileSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                importedSlavePublicKeyLabel.Text = masterController.importXMLWithPublicKey(fileSelector.FileName);   
            }
        }

        private void exportXMLpublicKeyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (slaveController.exportXMLWithPublicKey()) ?
                "XML creado en " + Environment.CurrentDirectory + @"\cp_esclavo.xml" :
                "XML no se pudo crear, verifique que la clave no este vacía.");
        }

        private void encryptTDESKeywithRSAButton_Click(object sender, EventArgs e)
        {
            encryptedKeyLabel.Text = masterController.encryptTDESKeyWithSlavePublicKey();
        }

        private void exportXMLWithEncryptedTDESButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (masterController.exportXMLWithEncryptedTDES(encryptedKeyLabel.Text)) ?
                "XML creado en " + Environment.CurrentDirectory + @"\tdesencriptado.xml" :
                "XML no se pudo crear, verifique que la clave no este vacía.");
        }

        private void importTDESKeyInXMLButton_Click(object sender, EventArgs e)
        {
            fileSelector.FileName = "tdesencriptado.xml";

            DialogResult dr = fileSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                importedMasterTDESKeyLabel.Text = slaveController.importTDESKeyInXML(fileSelector.FileName);
            }
        }

        private void decryptTDESButton_Click(object sender, EventArgs e)
        {
            decryptedMasterTDESKeyLabel.Text = slaveController.decryptTDESKey(importedMasterTDESKeyLabel.Text);
        }

        private void EncryptTextButton_Click(object sender, EventArgs e)
        {
            encryptedTextLabel.Text = slaveController.encryptText(textToEncryptInput.Text, decryptedMasterTDESKeyLabel.Text);
        }

        private void exportMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (slaveController.exportXMLWithEncryptedText(encryptedTextLabel.Text)) ?
                "XML creado en " + Environment.CurrentDirectory + @"\textoencriptado.xml" :
                "XML no se pudo crear, verifique que la clave no este vacía.");
        }

        private void importXMLMessageButton_Click(object sender, EventArgs e)
        {
            fileSelector.FileName = "textoencriptado.xml";

            DialogResult dr = fileSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                importedEncryptedMessageLabel.Text = masterController.importXMLMessage(fileSelector.FileName);
            }
        }

        private void DecryptTextButton_Click(object sender, EventArgs e)
        {
            decryptedImportedMessageLabel.Text = masterController.decryptText(importedEncryptedMessageLabel.Text);
        }
    }
}
