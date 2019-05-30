using System;
using System.Windows.Forms;

using DiatoCryptBack;

namespace DiatoCript
{

    public partial class Slave : Form
    {
        SlaveController slaveController;
        Master masterForm;

        public Slave()
        {
            InitializeComponent();
            slaveController = new SlaveController();
        }

        public void setMaster(Master master)
        {
            masterForm = master;
        }

        private void generateRSAKeysSlaveButton_Click(object sender, EventArgs e)
        {
            masterForm.generateAllRSAKeys();
        }

        public void generateAllRSAKeys()
        {
            KeyPair slaveKeys = slaveController.generateKeyPairRSA();

            slavePrivateKeyLabel.Text = slaveKeys.privateKey;
            slavePublicKeyLabel.Text = slaveKeys.publicKey;
        }

        private void exportXMLpublicKeyButton_Click(object sender, EventArgs e)
        {
            if (!slavePublicKeyLabel.Text.Equals(""))
            {
                MessageBox.Show(
                (slaveController.exportXMLWithPublicKey()) ?
                "XML creado en " + Environment.CurrentDirectory + @"\cp_esclavo.xml" :
                "XML no se pudo crear, verifique que la clave no este vacía.");
            }
            else
            {
                MessageBox.Show("No hay nada por exportar.");
            }
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
            try
            {
                decryptedMasterTDESKeyLabel.Text = slaveController.decryptTDESKey(importedMasterTDESKeyLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportMessageButton_Click(object sender, EventArgs e)
        {
            if (!encryptedTextLabel.Text.Equals(""))
            {
                MessageBox.Show(
                    (slaveController.exportXMLWithEncryptedText(encryptedTextLabel.Text)) ?
                    "XML creado en " + Environment.CurrentDirectory + @"\textoencriptado.xml" :
                    "XML no se pudo crear, verifique que la clave no este vacía.");
            }
            else
            {
                MessageBox.Show("No hay nada por exportar.");
            }
        }

        private void EncryptTextButton_Click(object sender, EventArgs e)
        {
            encryptedTextLabel.Text = slaveController.encryptText(textToEncryptInput.Text, decryptedMasterTDESKeyLabel.Text);
        }

    }
}
