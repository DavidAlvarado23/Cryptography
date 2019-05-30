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
            masterTDESKeyLabel.Text = masterController.generateTDESKey();
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
            encryptedKeyLabel.Text = masterController.encryptTDESKeyWithSlavePublicKey();
        }

        private void exportXMLWithEncryptedTDESButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (masterController.exportXMLWithEncryptedTDES(encryptedKeyLabel.Text)) ?
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
