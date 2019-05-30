using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show(
                (slaveController.exportXMLWithPublicKey()) ?
                "XML creado en " + Environment.CurrentDirectory + @"\cp_esclavo.xml" :
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

        private void exportMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                (slaveController.exportXMLWithEncryptedText(encryptedTextLabel.Text)) ?
                "XML creado en " + Environment.CurrentDirectory + @"\textoencriptado.xml" :
                "XML no se pudo crear, verifique que la clave no este vacía.");
        }

        private void EncryptTextButton_Click(object sender, EventArgs e)
        {
            encryptedTextLabel.Text = slaveController.encryptText(textToEncryptInput.Text, decryptedMasterTDESKeyLabel.Text);
        }

    }
}
