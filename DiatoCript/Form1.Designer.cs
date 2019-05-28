namespace DiatoCript
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.encryptedKeyLabel = new System.Windows.Forms.Label();
            this.importedSlavePublicKeyLabel = new System.Windows.Forms.Label();
            this.masterTDESKeyLabel = new System.Windows.Forms.Label();
            this.masterPrivateKeyLabel = new System.Windows.Forms.Label();
            this.masterPublicKeyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptTextButton = new System.Windows.Forms.Button();
            this.importXMLMessageButton = new System.Windows.Forms.Button();
            this.exportXMLWithEncryptedTDESButton = new System.Windows.Forms.Button();
            this.encryptTDESKeywithRSAButton = new System.Windows.Forms.Button();
            this.generateTDESKeyButton = new System.Windows.Forms.Button();
            this.importPublicKeyRSAButton = new System.Windows.Forms.Button();
            this.generateRSAKeysMasterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.encryptedTextLabel = new System.Windows.Forms.Label();
            this.decryptedMasterTDESKeyLabel = new System.Windows.Forms.Label();
            this.importedMasterTDESKeyLabel = new System.Windows.Forms.Label();
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
            this.importedEncryptedMessageLabel = new System.Windows.Forms.Label();
            this.decryptedImportedMessageLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.decryptedImportedMessageLabel);
            this.panel1.Controls.Add(this.importedEncryptedMessageLabel);
            this.panel1.Controls.Add(this.encryptedKeyLabel);
            this.panel1.Controls.Add(this.importedSlavePublicKeyLabel);
            this.panel1.Controls.Add(this.masterTDESKeyLabel);
            this.panel1.Controls.Add(this.masterPrivateKeyLabel);
            this.panel1.Controls.Add(this.masterPublicKeyLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DecryptTextButton);
            this.panel1.Controls.Add(this.importXMLMessageButton);
            this.panel1.Controls.Add(this.exportXMLWithEncryptedTDESButton);
            this.panel1.Controls.Add(this.encryptTDESKeywithRSAButton);
            this.panel1.Controls.Add(this.generateTDESKeyButton);
            this.panel1.Controls.Add(this.importPublicKeyRSAButton);
            this.panel1.Controls.Add(this.generateRSAKeysMasterButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 752);
            this.panel1.TabIndex = 0;
            // 
            // encryptedKeyLabel
            // 
            this.encryptedKeyLabel.AutoSize = true;
            this.encryptedKeyLabel.Location = new System.Drawing.Point(315, 412);
            this.encryptedKeyLabel.MaximumSize = new System.Drawing.Size(240, 0);
            this.encryptedKeyLabel.Name = "encryptedKeyLabel";
            this.encryptedKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.encryptedKeyLabel.TabIndex = 16;
            // 
            // importedSlavePublicKeyLabel
            // 
            this.importedSlavePublicKeyLabel.AutoSize = true;
            this.importedSlavePublicKeyLabel.Location = new System.Drawing.Point(311, 247);
            this.importedSlavePublicKeyLabel.MaximumSize = new System.Drawing.Size(240, 0);
            this.importedSlavePublicKeyLabel.Name = "importedSlavePublicKeyLabel";
            this.importedSlavePublicKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.importedSlavePublicKeyLabel.TabIndex = 15;
            // 
            // masterTDESKeyLabel
            // 
            this.masterTDESKeyLabel.AutoSize = true;
            this.masterTDESKeyLabel.Location = new System.Drawing.Point(239, 347);
            this.masterTDESKeyLabel.Name = "masterTDESKeyLabel";
            this.masterTDESKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.masterTDESKeyLabel.TabIndex = 14;
            // 
            // masterPrivateKeyLabel
            // 
            this.masterPrivateKeyLabel.AutoSize = true;
            this.masterPrivateKeyLabel.Location = new System.Drawing.Point(309, 160);
            this.masterPrivateKeyLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.masterPrivateKeyLabel.Name = "masterPrivateKeyLabel";
            this.masterPrivateKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.masterPrivateKeyLabel.TabIndex = 13;
            // 
            // masterPublicKeyLabel
            // 
            this.masterPublicKeyLabel.AutoSize = true;
            this.masterPublicKeyLabel.Location = new System.Drawing.Point(309, 87);
            this.masterPublicKeyLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.masterPublicKeyLabel.Name = "masterPublicKeyLabel";
            this.masterPublicKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.masterPublicKeyLabel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clave privada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave pública";
            // 
            // DecryptTextButton
            // 
            this.DecryptTextButton.BackColor = System.Drawing.Color.White;
            this.DecryptTextButton.FlatAppearance.BorderSize = 0;
            this.DecryptTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptTextButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptTextButton.Location = new System.Drawing.Point(23, 639);
            this.DecryptTextButton.Name = "DecryptTextButton";
            this.DecryptTextButton.Size = new System.Drawing.Size(320, 29);
            this.DecryptTextButton.TabIndex = 9;
            this.DecryptTextButton.Text = "Desencriptar texto con TDES y clave TDES creada";
            this.DecryptTextButton.UseVisualStyleBackColor = false;
            this.DecryptTextButton.Click += new System.EventHandler(this.DecryptTextButton_Click);
            // 
            // importXMLMessageButton
            // 
            this.importXMLMessageButton.BackColor = System.Drawing.Color.White;
            this.importXMLMessageButton.FlatAppearance.BorderSize = 0;
            this.importXMLMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importXMLMessageButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importXMLMessageButton.Location = new System.Drawing.Point(23, 537);
            this.importXMLMessageButton.Name = "importXMLMessageButton";
            this.importXMLMessageButton.Size = new System.Drawing.Size(195, 29);
            this.importXMLMessageButton.TabIndex = 8;
            this.importXMLMessageButton.Text = "Importar mensaje de XML";
            this.importXMLMessageButton.UseVisualStyleBackColor = false;
            this.importXMLMessageButton.Click += new System.EventHandler(this.importXMLMessageButton_Click);
            // 
            // exportXMLWithEncryptedTDESButton
            // 
            this.exportXMLWithEncryptedTDESButton.BackColor = System.Drawing.Color.White;
            this.exportXMLWithEncryptedTDESButton.FlatAppearance.BorderSize = 0;
            this.exportXMLWithEncryptedTDESButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportXMLWithEncryptedTDESButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportXMLWithEncryptedTDESButton.Location = new System.Drawing.Point(23, 495);
            this.exportXMLWithEncryptedTDESButton.Name = "exportXMLWithEncryptedTDESButton";
            this.exportXMLWithEncryptedTDESButton.Size = new System.Drawing.Size(529, 26);
            this.exportXMLWithEncryptedTDESButton.TabIndex = 7;
            this.exportXMLWithEncryptedTDESButton.Text = "Exportar XML TDES encriptada";
            this.exportXMLWithEncryptedTDESButton.UseVisualStyleBackColor = false;
            this.exportXMLWithEncryptedTDESButton.Click += new System.EventHandler(this.exportXMLWithEncryptedTDESButton_Click);
            // 
            // encryptTDESKeywithRSAButton
            // 
            this.encryptTDESKeywithRSAButton.BackColor = System.Drawing.Color.White;
            this.encryptTDESKeywithRSAButton.FlatAppearance.BorderSize = 0;
            this.encryptTDESKeywithRSAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encryptTDESKeywithRSAButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptTDESKeywithRSAButton.Location = new System.Drawing.Point(21, 406);
            this.encryptTDESKeywithRSAButton.Name = "encryptTDESKeywithRSAButton";
            this.encryptTDESKeywithRSAButton.Size = new System.Drawing.Size(282, 49);
            this.encryptTDESKeywithRSAButton.TabIndex = 6;
            this.encryptTDESKeywithRSAButton.Text = "Encriptar clave TDES con RSA y clave pública esclavo";
            this.encryptTDESKeywithRSAButton.UseVisualStyleBackColor = false;
            this.encryptTDESKeywithRSAButton.Click += new System.EventHandler(this.encryptTDESKeywithRSAButton_Click);
            // 
            // generateTDESKeyButton
            // 
            this.generateTDESKeyButton.BackColor = System.Drawing.Color.White;
            this.generateTDESKeyButton.FlatAppearance.BorderSize = 0;
            this.generateTDESKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateTDESKeyButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateTDESKeyButton.Location = new System.Drawing.Point(23, 339);
            this.generateTDESKeyButton.Name = "generateTDESKeyButton";
            this.generateTDESKeyButton.Size = new System.Drawing.Size(195, 29);
            this.generateTDESKeyButton.TabIndex = 5;
            this.generateTDESKeyButton.Text = "Generar clave TDES";
            this.generateTDESKeyButton.UseVisualStyleBackColor = false;
            this.generateTDESKeyButton.Click += new System.EventHandler(this.generateTDESKeyButton_Click);
            // 
            // importPublicKeyRSAButton
            // 
            this.importPublicKeyRSAButton.BackColor = System.Drawing.Color.White;
            this.importPublicKeyRSAButton.FlatAppearance.BorderSize = 0;
            this.importPublicKeyRSAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importPublicKeyRSAButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importPublicKeyRSAButton.Location = new System.Drawing.Point(23, 247);
            this.importPublicKeyRSAButton.Name = "importPublicKeyRSAButton";
            this.importPublicKeyRSAButton.Size = new System.Drawing.Size(282, 29);
            this.importPublicKeyRSAButton.TabIndex = 4;
            this.importPublicKeyRSAButton.Text = "Importar clave pública RSA esclavo";
            this.importPublicKeyRSAButton.UseVisualStyleBackColor = false;
            this.importPublicKeyRSAButton.Click += new System.EventHandler(this.importPublicKeyRSAButton_Click);
            // 
            // generateRSAKeysMasterButton
            // 
            this.generateRSAKeysMasterButton.BackColor = System.Drawing.Color.White;
            this.generateRSAKeysMasterButton.FlatAppearance.BorderSize = 0;
            this.generateRSAKeysMasterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateRSAKeysMasterButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRSAKeysMasterButton.Location = new System.Drawing.Point(23, 114);
            this.generateRSAKeysMasterButton.Name = "generateRSAKeysMasterButton";
            this.generateRSAKeysMasterButton.Size = new System.Drawing.Size(167, 29);
            this.generateRSAKeysMasterButton.TabIndex = 3;
            this.generateRSAKeysMasterButton.Text = "Generar claves RSA";
            this.generateRSAKeysMasterButton.UseVisualStyleBackColor = false;
            this.generateRSAKeysMasterButton.Click += new System.EventHandler(this.generateRSAKeysMasterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAESTRO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.encryptedTextLabel);
            this.panel2.Controls.Add(this.decryptedMasterTDESKeyLabel);
            this.panel2.Controls.Add(this.importedMasterTDESKeyLabel);
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
            this.panel2.Location = new System.Drawing.Point(595, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 752);
            this.panel2.TabIndex = 1;
            // 
            // encryptedTextLabel
            // 
            this.encryptedTextLabel.AutoSize = true;
            this.encryptedTextLabel.Location = new System.Drawing.Point(26, 546);
            this.encryptedTextLabel.MaximumSize = new System.Drawing.Size(520, 0);
            this.encryptedTextLabel.Name = "encryptedTextLabel";
            this.encryptedTextLabel.Size = new System.Drawing.Size(0, 13);
            this.encryptedTextLabel.TabIndex = 18;
            // 
            // decryptedMasterTDESKeyLabel
            // 
            this.decryptedMasterTDESKeyLabel.AutoSize = true;
            this.decryptedMasterTDESKeyLabel.Location = new System.Drawing.Point(235, 310);
            this.decryptedMasterTDESKeyLabel.MaximumSize = new System.Drawing.Size(330, 0);
            this.decryptedMasterTDESKeyLabel.Name = "decryptedMasterTDESKeyLabel";
            this.decryptedMasterTDESKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.decryptedMasterTDESKeyLabel.TabIndex = 17;
            // 
            // importedMasterTDESKeyLabel
            // 
            this.importedMasterTDESKeyLabel.AutoSize = true;
            this.importedMasterTDESKeyLabel.Location = new System.Drawing.Point(233, 235);
            this.importedMasterTDESKeyLabel.MaximumSize = new System.Drawing.Size(330, 0);
            this.importedMasterTDESKeyLabel.Name = "importedMasterTDESKeyLabel";
            this.importedMasterTDESKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.importedMasterTDESKeyLabel.TabIndex = 16;
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
            this.textToEncryptInput.Location = new System.Drawing.Point(139, 374);
            this.textToEncryptInput.Name = "textToEncryptInput";
            this.textToEncryptInput.Size = new System.Drawing.Size(402, 99);
            this.textToEncryptInput.TabIndex = 15;
            this.textToEncryptInput.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 376);
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
            this.EncryptTextButton.Location = new System.Drawing.Point(23, 492);
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
            this.decryptTDESButton.Location = new System.Drawing.Point(23, 306);
            this.decryptTDESButton.Name = "decryptTDESButton";
            this.decryptTDESButton.Size = new System.Drawing.Size(195, 34);
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
            this.importTDESKeyInXMLButton.Size = new System.Drawing.Size(195, 49);
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
    "ía\\DiatoCript\\DiatoCript\\bin\\Debug";
            this.fileSelector.Title = "Seleccione el archivo a importar";
            // 
            // importedEncryptedMessageLabel
            // 
            this.importedEncryptedMessageLabel.AutoSize = true;
            this.importedEncryptedMessageLabel.Location = new System.Drawing.Point(27, 576);
            this.importedEncryptedMessageLabel.Name = "importedEncryptedMessageLabel";
            this.importedEncryptedMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.importedEncryptedMessageLabel.TabIndex = 17;
            // 
            // decryptedImportedMessageLabel
            // 
            this.decryptedImportedMessageLabel.AutoSize = true;
            this.decryptedImportedMessageLabel.Location = new System.Drawing.Point(27, 681);
            this.decryptedImportedMessageLabel.Name = "decryptedImportedMessageLabel";
            this.decryptedImportedMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.decryptedImportedMessageLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 776);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button importPublicKeyRSAButton;
        private System.Windows.Forms.Button generateRSAKeysMasterButton;
        private System.Windows.Forms.Button encryptTDESKeywithRSAButton;
        private System.Windows.Forms.Button generateTDESKeyButton;
        private System.Windows.Forms.Button exportXMLWithEncryptedTDESButton;
        private System.Windows.Forms.Button DecryptTextButton;
        private System.Windows.Forms.Button importXMLMessageButton;
        private System.Windows.Forms.Button exportMessageButton;
        private System.Windows.Forms.Button EncryptTextButton;
        private System.Windows.Forms.Button decryptTDESButton;
        private System.Windows.Forms.Button importTDESKeyInXMLButton;
        private System.Windows.Forms.Button exportXMLpublicKeyButton;
        private System.Windows.Forms.Button generateRSAKeysSlaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textToEncryptInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label masterPrivateKeyLabel;
        private System.Windows.Forms.Label masterPublicKeyLabel;
        private System.Windows.Forms.Label masterTDESKeyLabel;
        private System.Windows.Forms.Label slavePrivateKeyLabel;
        private System.Windows.Forms.Label slavePublicKeyLabel;
        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.Label importedSlavePublicKeyLabel;
        private System.Windows.Forms.Label encryptedKeyLabel;
        private System.Windows.Forms.Label importedMasterTDESKeyLabel;
        private System.Windows.Forms.Label decryptedMasterTDESKeyLabel;
        private System.Windows.Forms.Label encryptedTextLabel;
        private System.Windows.Forms.Label decryptedImportedMessageLabel;
        private System.Windows.Forms.Label importedEncryptedMessageLabel;
    }
}

