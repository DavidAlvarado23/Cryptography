using System;
using System.Windows.Forms;

using DiatoCryptBack;

namespace DiatoCript
{
    public partial class Master : Form
    {
        MasterController masterController;
        Slave slaveForm;

        public Master()
        {
            InitializeComponent();
            masterController = new MasterController();
        }

        public void setSlave(Slave slave)
        {
            slaveForm = slave;
        }

        private void generateTDESKeyButton_Click(object sender, EventArgs e)
        {
            string[] keys = masterController.generateTDESKey();
            masterTDESKey1Label.Text = keys[0];
            masterTDESKey2Label.Text = keys[1];
            masterTDESKey3Label.Text = keys[2];
        }

        private void generateRSAKeysMasterButton_Click(object sender, EventArgs e)
        {
            generateAllRSAKeys();
        }

        public void generateAllRSAKeys()
        {
            KeyPair masterKeys = masterController.generateKeyPairRSA();

            masterPrivateKeyLabel.Text = masterKeys.privateKey;
            masterPublicKeyLabel.Text = masterKeys.publicKey;

            slaveForm.generateAllRSAKeys();
        }

        private void importPublicKeyRSAButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = fileSelector.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    importedSlavePublicKeyLabel.Text = masterController.importXMLWithPublicKey(fileSelector.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void encryptTDESKeywithRSAButton_Click(object sender, EventArgs e)
        {
            string[] encryptedData = masterController.encryptTDESKeyWithSlavePublicKey();
            if (encryptedData != null)
            {
                encryptedKey1Label.Text = encryptedData[0];
                encryptedKey2Label.Text = encryptedData[1];
                encryptedKey3Label.Text = encryptedData[2];
            }
            else
            {
                MessageBox.Show("No se encontró clave pública de esclavo");
            }
        }

        private void exportXMLWithEncryptedTDESButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (masterController.exportXMLWithEncryptedTDES(encryptedKey1Label.Text, encryptedKey2Label.Text, encryptedKey3Label.Text)) ?
                "XML creado en " + Environment.CurrentDirectory + @"\tdesencriptado.xml" :
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
            try
            {
                decryptedImportedMessageLabel.Text = masterController.decryptText(importedEncryptedMessageLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
