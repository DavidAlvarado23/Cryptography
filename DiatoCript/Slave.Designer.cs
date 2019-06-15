using System.IO;

namespace DiatoCript
{
    partial class Slave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.importedMasterTDESKey3Label = new System.Windows.Forms.Label();
            this.importedMasterTDESKey2Label = new System.Windows.Forms.Label();
            this.decryptedMasterTDESKey3Label = new System.Windows.Forms.Label();
            this.decryptedMasterTDESKey2Label = new System.Windows.Forms.Label();
            this.encryptedTextLabel = new System.Windows.Forms.Label();
            this.decryptedMasterTDESKey1Label = new System.Windows.Forms.Label();
            this.importedMasterTDESKey1Label = new System.Windows.Forms.Label();
            this.slavePrivateKeyLabel = new System.Windows.Forms.Label();
            this.slavePublicKeyLabel = new System.Windows.Forms.Label();
            this.textToEncryptInput = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exportMessageButton = new System.Windows.Forms.Button();
            this.EncryptTextButton = new System.Windows.Forms.Button();
            this.decryptTDESButton = new System.Windows.Forms.Button();
            this.importTDESKeyInXMLButton = new System.Windows.Forms.Button();
            this.exportXMLpublicKeyButton = new System.Windows.Forms.Button();
            this.generateRSAKeysSlaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.importedMasterTDESKey3Label);
            this.panel2.Controls.Add(this.importedMasterTDESKey2Label);
            this.panel2.Controls.Add(this.decryptedMasterTDESKey3Label);
            this.panel2.Controls.Add(this.decryptedMasterTDESKey2Label);
            this.panel2.Controls.Add(this.encryptedTextLabel);
            this.panel2.Controls.Add(this.decryptedMasterTDESKey1Label);
            this.panel2.Controls.Add(this.importedMasterTDESKey1Label);
            this.panel2.Controls.Add(this.slavePrivateKeyLabel);
            this.panel2.Controls.Add(this.slavePublicKeyLabel);
            this.panel2.Controls.Add(this.textToEncryptInput);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.exportMessageButton);
            this.panel2.Controls.Add(this.EncryptTextButton);
            this.panel2.Controls.Add(this.decryptTDESButton);
            this.panel2.Controls.Add(this.importTDESKeyInXMLButton);
            this.panel2.Controls.Add(this.exportXMLpublicKeyButton);
            this.panel2.Controls.Add(this.generateRSAKeysSlaveButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 752);
            this.panel2.TabIndex = 1;
            // 
            // importedMasterTDESKey3Label
            // 
            this.importedMasterTDESKey3Label.AutoSize = true;
            this.importedMasterTDESKey3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.927273F);
            this.importedMasterTDESKey3Label.Location = new System.Drawing.Point(179, 334);
            this.importedMasterTDESKey3Label.MaximumSize = new System.Drawing.Size(385, 0);
            this.importedMasterTDESKey3Label.Name = "importedMasterTDESKey3Label";
            this.importedMasterTDESKey3Label.Size = new System.Drawing.Size(0, 13);
            this.importedMasterTDESKey3Label.TabIndex = 22;
            // 
            // importedMasterTDESKey2Label
            // 
            this.importedMasterTDESKey2Label.AutoSize = true;
            this.importedMasterTDESKey2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.927273F);
            this.importedMasterTDESKey2Label.Location = new System.Drawing.Point(179, 286);
            this.importedMasterTDESKey2Label.MaximumSize = new System.Drawing.Size(385, 0);
            this.importedMasterTDESKey2Label.Name = "importedMasterTDESKey2Label";
            this.importedMasterTDESKey2Label.Size = new System.Drawing.Size(0, 13);
            this.importedMasterTDESKey2Label.TabIndex = 21;
            // 
            // decryptedMasterTDESKey3Label
            // 
            this.decryptedMasterTDESKey3Label.AutoSize = true;
            this.decryptedMasterTDESKey3Label.Location = new System.Drawing.Point(233, 427);
            this.decryptedMasterTDESKey3Label.MaximumSize = new System.Drawing.Size(330, 0);
            this.decryptedMasterTDESKey3Label.Name = "decryptedMasterTDESKey3Label";
            this.decryptedMasterTDESKey3Label.Size = new System.Drawing.Size(0, 13);
            this.decryptedMasterTDESKey3Label.TabIndex = 20;
            // 
            // decryptedMasterTDESKey2Label
            // 
            this.decryptedMasterTDESKey2Label.AutoSize = true;
            this.decryptedMasterTDESKey2Label.Location = new System.Drawing.Point(233, 407);
            this.decryptedMasterTDESKey2Label.MaximumSize = new System.Drawing.Size(330, 0);
            this.decryptedMasterTDESKey2Label.Name = "decryptedMasterTDESKey2Label";
            this.decryptedMasterTDESKey2Label.Size = new System.Drawing.Size(0, 13);
            this.decryptedMasterTDESKey2Label.TabIndex = 19;
            // 
            // encryptedTextLabel
            // 
            this.encryptedTextLabel.AutoSize = true;
            this.encryptedTextLabel.Location = new System.Drawing.Point(29, 606);
            this.encryptedTextLabel.MaximumSize = new System.Drawing.Size(520, 0);
            this.encryptedTextLabel.Name = "encryptedTextLabel";
            this.encryptedTextLabel.Size = new System.Drawing.Size(0, 13);
            this.encryptedTextLabel.TabIndex = 18;
            // 
            // decryptedMasterTDESKey1Label
            // 
            this.decryptedMasterTDESKey1Label.AutoSize = true;
            this.decryptedMasterTDESKey1Label.Location = new System.Drawing.Point(233, 385);
            this.decryptedMasterTDESKey1Label.MaximumSize = new System.Drawing.Size(330, 0);
            this.decryptedMasterTDESKey1Label.Name = "decryptedMasterTDESKey1Label";
            this.decryptedMasterTDESKey1Label.Size = new System.Drawing.Size(0, 13);
            this.decryptedMasterTDESKey1Label.TabIndex = 17;
            // 
            // importedMasterTDESKey1Label
            // 
            this.importedMasterTDESKey1Label.AutoSize = true;
            this.importedMasterTDESKey1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.927273F);
            this.importedMasterTDESKey1Label.Location = new System.Drawing.Point(179, 235);
            this.importedMasterTDESKey1Label.MaximumSize = new System.Drawing.Size(385, 0);
            this.importedMasterTDESKey1Label.Name = "importedMasterTDESKey1Label";
            this.importedMasterTDESKey1Label.Size = new System.Drawing.Size(0, 13);
            this.importedMasterTDESKey1Label.TabIndex = 16;
            // 
            // slavePrivateKeyLabel
            // 
            this.slavePrivateKeyLabel.AutoSize = true;
            this.slavePrivateKeyLabel.Location = new System.Drawing.Point(309, 160);
            this.slavePrivateKeyLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.slavePrivateKeyLabel.Name = "slavePrivateKeyLabel";
            this.slavePrivateKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.slavePrivateKeyLabel.TabIndex = 15;
            // 
            // slavePublicKeyLabel
            // 
            this.slavePublicKeyLabel.AutoSize = true;
            this.slavePublicKeyLabel.Location = new System.Drawing.Point(309, 87);
            this.slavePublicKeyLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.slavePublicKeyLabel.Name = "slavePublicKeyLabel";
            this.slavePublicKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.slavePublicKeyLabel.TabIndex = 15;
            // 
            // textToEncryptInput
            // 
            this.textToEncryptInput.Location = new System.Drawing.Point(139, 457);
            this.textToEncryptInput.Name = "textToEncryptInput";
            this.textToEncryptInput.Size = new System.Drawing.Size(402, 99);
            this.textToEncryptInput.TabIndex = 15;
            this.textToEncryptInput.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Introducir texto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clave privada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Clave pública";
            // 
            // exportMessageButton
            // 
            this.exportMessageButton.BackColor = System.Drawing.Color.White;
            this.exportMessageButton.FlatAppearance.BorderSize = 0;
            this.exportMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportMessageButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportMessageButton.Location = new System.Drawing.Point(346, 702);
            this.exportMessageButton.Name = "exportMessageButton";
            this.exportMessageButton.Size = new System.Drawing.Size(195, 29);
            this.exportMessageButton.TabIndex = 10;
            this.exportMessageButton.Text = "Exportar mensaje de XML";
            this.exportMessageButton.UseVisualStyleBackColor = false;
            this.exportMessageButton.Click += new System.EventHandler(this.exportMessageButton_Click);
            // 
            // EncryptTextButton
            // 
            this.EncryptTextButton.BackColor = System.Drawing.Color.White;
            this.EncryptTextButton.FlatAppearance.BorderSize = 0;
            this.EncryptTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptTextButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTextButton.Location = new System.Drawing.Point(23, 568);
            this.EncryptTextButton.Name = "EncryptTextButton";
            this.EncryptTextButton.Size = new System.Drawing.Size(518, 29);
            this.EncryptTextButton.TabIndex = 12;
            this.EncryptTextButton.Text = "Encriptar texto algoritmo TDES y clave TDES desencriptada";
            this.EncryptTextButton.UseVisualStyleBackColor = false;
            this.EncryptTextButton.Click += new System.EventHandler(this.EncryptTextButton_Click);
            // 
            // decryptTDESButton
            // 
            this.decryptTDESButton.BackColor = System.Drawing.Color.White;
            this.decryptTDESButton.FlatAppearance.BorderSize = 0;
            this.decryptTDESButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decryptTDESButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptTDESButton.Location = new System.Drawing.Point(23, 386);
            this.decryptTDESButton.Name = "decryptTDESButton";
            this.decryptTDESButton.Size = new System.Drawing.Size(195, 55);
            this.decryptTDESButton.TabIndex = 11;
            this.decryptTDESButton.Text = "Desencriptar TDES de fichero";
            this.decryptTDESButton.UseVisualStyleBackColor = false;
            this.decryptTDESButton.Click += new System.EventHandler(this.decryptTDESButton_Click);
            // 
            // importTDESKeyInXMLButton
            // 
            this.importTDESKeyInXMLButton.BackColor = System.Drawing.Color.White;
            this.importTDESKeyInXMLButton.FlatAppearance.BorderSize = 0;
            this.importTDESKeyInXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importTDESKeyInXMLButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTDESKeyInXMLButton.Location = new System.Drawing.Point(23, 232);
            this.importTDESKeyInXMLButton.Name = "importTDESKeyInXMLButton";
            this.importTDESKeyInXMLButton.Size = new System.Drawing.Size(144, 67);
            this.importTDESKeyInXMLButton.TabIndex = 10;
            this.importTDESKeyInXMLButton.Text = "Importar clave TDES de fichero XML";
            this.importTDESKeyInXMLButton.UseVisualStyleBackColor = false;
            this.importTDESKeyInXMLButton.Click += new System.EventHandler(this.importTDESKeyInXMLButton_Click);
            // 
            // exportXMLpublicKeyButton
            // 
            this.exportXMLpublicKeyButton.BackColor = System.Drawing.Color.White;
            this.exportXMLpublicKeyButton.FlatAppearance.BorderSize = 0;
            this.exportXMLpublicKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportXMLpublicKeyButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportXMLpublicKeyButton.Location = new System.Drawing.Point(23, 160);
            this.exportXMLpublicKeyButton.Name = "exportXMLpublicKeyButton";
            this.exportXMLpublicKeyButton.Size = new System.Drawing.Size(167, 51);
            this.exportXMLpublicKeyButton.TabIndex = 10;
            this.exportXMLpublicKeyButton.Text = "Exportar XML clave pública";
            this.exportXMLpublicKeyButton.UseVisualStyleBackColor = false;
            this.exportXMLpublicKeyButton.Click += new System.EventHandler(this.exportXMLpublicKeyButton_Click);
            // 
            // generateRSAKeysSlaveButton
            // 
            this.generateRSAKeysSlaveButton.BackColor = System.Drawing.Color.White;
            this.generateRSAKeysSlaveButton.FlatAppearance.BorderSize = 0;
            this.generateRSAKeysSlaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateRSAKeysSlaveButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRSAKeysSlaveButton.Location = new System.Drawing.Point(23, 114);
            this.generateRSAKeysSlaveButton.Name = "generateRSAKeysSlaveButton";
            this.generateRSAKeysSlaveButton.Size = new System.Drawing.Size(167, 29);
            this.generateRSAKeysSlaveButton.TabIndex = 10;
            this.generateRSAKeysSlaveButton.Text = "Generar claves RSA";
            this.generateRSAKeysSlaveButton.UseVisualStyleBackColor = false;
            this.generateRSAKeysSlaveButton.Click += new System.EventHandler(this.generateRSAKeysSlaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "ESCLAVO";
            // 
            // fileSelector
            // 
            this.fileSelector.DefaultExt = "xml";
            this.fileSelector.FileName = "cp_esclavo.xml";
            this.fileSelector.Filter = "Fichero XML (*.xml)|*.xml;";
            this.fileSelector.InitialDirectory = "C:\\Users\\David23\\Desktop\\Uneatlántico\\Ciclo VI\\Seguridad Informática y Criptograf" +
    "ía\\DiatoCript";
            this.fileSelector.Title = "Seleccione el archivo a importar";
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 776);
            this.Controls.Add(this.panel2);
            this.Name = "Slave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slave";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.Label slavePrivateKeyLabel;
        private System.Windows.Forms.Label slavePublicKeyLabel;
        private System.Windows.Forms.Button generateRSAKeysSlaveButton;
        private System.Windows.Forms.Button exportXMLpublicKeyButton;
        private System.Windows.Forms.Button importTDESKeyInXMLButton;
        private System.Windows.Forms.Label importedMasterTDESKey1Label;
        private System.Windows.Forms.Button decryptTDESButton;
        private System.Windows.Forms.Label decryptedMasterTDESKey1Label;
        private System.Windows.Forms.RichTextBox textToEncryptInput;
        private System.Windows.Forms.Button EncryptTextButton;
        private System.Windows.Forms.Button exportMessageButton;
        private System.Windows.Forms.Label encryptedTextLabel;
        private System.Windows.Forms.Label importedMasterTDESKey3Label;
        private System.Windows.Forms.Label importedMasterTDESKey2Label;
        private System.Windows.Forms.Label decryptedMasterTDESKey3Label;
        private System.Windows.Forms.Label decryptedMasterTDESKey2Label;
    }
}