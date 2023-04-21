namespace Cryptron
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            Transposition = new RadioButton();
            RVernam = new RadioButton();
            RVigenere = new RadioButton();
            groupBox2 = new GroupBox();
            bttnGenerateKey = new Button();
            tbKey = new TextBox();
            groupBox3 = new GroupBox();
            rtbMessage = new RichTextBox();
            btnSaveFile = new Button();
            btnBrowseFiles = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 50);
            label1.TabIndex = 0;
            label1.Text = "CRYPTRON";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(Transposition);
            groupBox1.Controls.Add(RVernam);
            groupBox1.Controls.Add(RVigenere);
            groupBox1.Location = new Point(27, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 80);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Encpryption Method";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(107, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Transposition
            // 
            Transposition.AutoSize = true;
            Transposition.Location = new Point(6, 47);
            Transposition.Name = "Transposition";
            Transposition.Size = new Size(95, 19);
            Transposition.TabIndex = 2;
            Transposition.TabStop = true;
            Transposition.Text = "Transposition";
            Transposition.UseVisualStyleBackColor = true;
            Transposition.CheckedChanged += Transposition_CheckedChanged;
            // 
            // RVernam
            // 
            RVernam.AutoSize = true;
            RVernam.Location = new Point(87, 21);
            RVernam.Name = "RVernam";
            RVernam.Size = new Size(65, 19);
            RVernam.TabIndex = 1;
            RVernam.TabStop = true;
            RVernam.Text = "Vernam";
            RVernam.UseVisualStyleBackColor = true;
            // 
            // RVigenere
            // 
            RVigenere.AutoSize = true;
            RVigenere.Location = new Point(6, 22);
            RVigenere.Name = "RVigenere";
            RVigenere.Size = new Size(74, 19);
            RVigenere.TabIndex = 0;
            RVigenere.TabStop = true;
            RVigenere.Text = "Vigenere ";
            RVigenere.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bttnGenerateKey);
            groupBox2.Controls.Add(tbKey);
            groupBox2.Location = new Point(248, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 80);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter key or generate a random key ";
            // 
            // bttnGenerateKey
            // 
            bttnGenerateKey.Location = new Point(15, 50);
            bttnGenerateKey.Name = "bttnGenerateKey";
            bttnGenerateKey.Size = new Size(489, 23);
            bttnGenerateKey.TabIndex = 1;
            bttnGenerateKey.Text = "Generate key ";
            bttnGenerateKey.UseVisualStyleBackColor = true;
            bttnGenerateKey.Click += bttnGenerateKey_Click;
            // 
            // tbKey
            // 
            tbKey.Location = new Point(15, 21);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(489, 23);
            tbKey.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtbMessage);
            groupBox3.Controls.Add(btnSaveFile);
            groupBox3.Controls.Add(btnBrowseFiles);
            groupBox3.Controls.Add(btnDecrypt);
            groupBox3.Controls.Add(btnEncrypt);
            groupBox3.Location = new Point(27, 168);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(731, 269);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Encrypt/Decrypt ";
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(124, 33);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(601, 213);
            rtbMessage.TabIndex = 6;
            rtbMessage.Text = "Enter message here or browse for files to encrypt or decrypt ";
            rtbMessage.TextChanged += rtbMessage_TextChanged;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(17, 195);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(99, 52);
            btnSaveFile.TabIndex = 1;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnBrowseFiles
            // 
            btnBrowseFiles.Location = new Point(17, 32);
            btnBrowseFiles.Name = "btnBrowseFiles";
            btnBrowseFiles.Size = new Size(99, 46);
            btnBrowseFiles.TabIndex = 0;
            btnBrowseFiles.Text = "Browse Files";
            btnBrowseFiles.UseVisualStyleBackColor = true;
            btnBrowseFiles.Click += btnBrowseFiles_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(17, 141);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(99, 48);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(17, 84);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(99, 51);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(777, 455);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cryptron";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton Transposition;
        private RadioButton RVernam;
        private RadioButton RVigenere;
        private GroupBox groupBox2;
        private Button bttnGenerateKey;
        private TextBox tbKey;
        private GroupBox groupBox3;
        private Button btnBrowseFiles;
        private Button btnSaveFile;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private RichTextBox rtbMessage;
    }
}