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
            rbAES = new RadioButton();
            radioButton4 = new RadioButton();
            Transposition = new RadioButton();
            RVernam = new RadioButton();
            RVigenere = new RadioButton();
            groupBox2 = new GroupBox();
            tbKey = new RichTextBox();
            bttnGenerateKey = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
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
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(315, 63);
            label1.TabIndex = 0;
            label1.Text = "CRYPTRON";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAES);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(Transposition);
            groupBox1.Controls.Add(RVernam);
            groupBox1.Controls.Add(RVigenere);
            groupBox1.Location = new Point(31, 97);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(262, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Encpryption Method";
            // 
            // rbAES
            // 
            rbAES.AutoSize = true;
            rbAES.Location = new Point(181, 28);
            rbAES.Margin = new Padding(3, 4, 3, 4);
            rbAES.Name = "rbAES";
            rbAES.Size = new Size(56, 24);
            rbAES.TabIndex = 4;
            rbAES.TabStop = true;
            rbAES.Text = "AES";
            rbAES.UseVisualStyleBackColor = true;
            rbAES.CheckedChanged += rbAES_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(122, 63);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ceasar";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Transposition
            // 
            Transposition.AutoSize = true;
            Transposition.Location = new Point(7, 63);
            Transposition.Margin = new Padding(3, 4, 3, 4);
            Transposition.Name = "Transposition";
            Transposition.Size = new Size(118, 24);
            Transposition.TabIndex = 2;
            Transposition.TabStop = true;
            Transposition.Text = "Transposition";
            Transposition.UseVisualStyleBackColor = true;
            Transposition.CheckedChanged += Transposition_CheckedChanged;
            // 
            // RVernam
            // 
            RVernam.AutoSize = true;
            RVernam.Location = new Point(99, 28);
            RVernam.Margin = new Padding(3, 4, 3, 4);
            RVernam.Name = "RVernam";
            RVernam.Size = new Size(80, 24);
            RVernam.TabIndex = 1;
            RVernam.TabStop = true;
            RVernam.Text = "Vernam";
            RVernam.UseVisualStyleBackColor = true;
            // 
            // RVigenere
            // 
            RVigenere.AutoSize = true;
            RVigenere.Location = new Point(7, 29);
            RVigenere.Margin = new Padding(3, 4, 3, 4);
            RVigenere.Name = "RVigenere";
            RVigenere.Size = new Size(93, 24);
            RVigenere.TabIndex = 0;
            RVigenere.TabStop = true;
            RVigenere.Text = "Vigenere ";
            RVigenere.UseVisualStyleBackColor = true;
            RVigenere.CheckedChanged += RVigenere_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbKey);
            groupBox2.Controls.Add(bttnGenerateKey);
            groupBox2.Location = new Point(318, 97);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(549, 107);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter key or generate a random key ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // tbKey
            // 
            tbKey.Location = new Point(17, 25);
            tbKey.Margin = new Padding(3, 4, 3, 4);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(525, 32);
            tbKey.TabIndex = 2;
            tbKey.Text = "";
            // 
            // bttnGenerateKey
            // 
            bttnGenerateKey.Location = new Point(15, 68);
            bttnGenerateKey.Margin = new Padding(3, 4, 3, 4);
            bttnGenerateKey.Name = "bttnGenerateKey";
            bttnGenerateKey.Size = new Size(528, 31);
            bttnGenerateKey.TabIndex = 1;
            bttnGenerateKey.Text = "Generate key ";
            bttnGenerateKey.UseVisualStyleBackColor = true;
            bttnGenerateKey.Click += bttnGenerateKey_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(rtbMessage);
            groupBox3.Controls.Add(btnSaveFile);
            groupBox3.Controls.Add(btnBrowseFiles);
            groupBox3.Controls.Add(btnDecrypt);
            groupBox3.Controls.Add(btnEncrypt);
            groupBox3.Location = new Point(31, 224);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(835, 359);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Encrypt/Decrypt ";
            // 
            // button2
            // 
            button2.Location = new Point(19, 276);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(115, 52);
            button2.TabIndex = 8;
            button2.Text = "Book Cipher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 39);
            button1.TabIndex = 7;
            button1.Text = "Clear ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(142, 44);
            rtbMessage.Margin = new Padding(3, 4, 3, 4);
            rtbMessage.MaxLength = 1000000;
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(686, 283);
            rtbMessage.TabIndex = 6;
            rtbMessage.Text = "Enter message here or browse for files to encrypt or decrypt ";
            rtbMessage.TextChanged += rtbMessage_TextChanged;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(19, 183);
            btnSaveFile.Margin = new Padding(3, 4, 3, 4);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(115, 39);
            btnSaveFile.TabIndex = 1;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnBrowseFiles
            // 
            btnBrowseFiles.Location = new Point(19, 43);
            btnBrowseFiles.Margin = new Padding(3, 4, 3, 4);
            btnBrowseFiles.Name = "btnBrowseFiles";
            btnBrowseFiles.Size = new Size(115, 39);
            btnBrowseFiles.TabIndex = 0;
            btnBrowseFiles.Text = "Browse Files";
            btnBrowseFiles.UseVisualStyleBackColor = true;
            btnBrowseFiles.Click += btnBrowseFiles_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(19, 136);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(115, 39);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(19, 89);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(115, 39);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(874, 613);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Cryptron";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox3;
        private Button btnBrowseFiles;
        private Button btnSaveFile;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private RichTextBox rtbMessage;
        private Button button1;
        private RichTextBox tbKey;
        private Button button2;
        private RadioButton rbAES;
    }
}