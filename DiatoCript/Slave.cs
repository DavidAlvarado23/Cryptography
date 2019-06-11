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
                string[] data = slaveController.importTDESKeyInXML(fileSelector.FileName);
                if (data != null)
                {
                    importedMasterTDESKey1Label.Text = data[0];
                    importedMasterTDESKey2Label.Text = data[1];
                    importedMasterTDESKey3Label.Text = data[2];
                }
                else
                {
                    MessageBox.Show("El formato no es correcto");
                }
            }
        }

        private void decryptTDESButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = slaveController.decryptTDESKey(importedMasterTDESKey1Label.Text, importedMasterTDESKey2Label.Text, importedMasterTDESKey3Label.Text);

                decryptedMasterTDESKey1Label.Text = data[0];
                decryptedMasterTDESKey2Label.Text = data[1];
                decryptedMasterTDESKey3Label.Text = data[2];
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
            encryptedTextLabel.Text = slaveController.encryptText(textToEncryptInput.Text, decryptedMasterTDESKey1Label.Text, decryptedMasterTDESKey2Label.Text, decryptedMasterTDESKey3Label.Text);
        }

    }
}
