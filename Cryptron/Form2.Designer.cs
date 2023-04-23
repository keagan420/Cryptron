namespace Cryptron
{
    partial class Form2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGenerateKey = new Button();
            tbKey = new RichTextBox();
            groupBox2 = new GroupBox();
            btnDecrypt = new Button();
            btnSave = new Button();
            btnEncrypt = new Button();
            btnOpen = new Button();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            tbMessage = new RichTextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(660, 50);
            label1.TabIndex = 1;
            label1.Text = "CRYPTRON STEGANOGRAPHY";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerateKey);
            groupBox1.Controls.Add(tbKey);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(26, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter key or generate random key ";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateKey.Location = new Point(452, 24);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(155, 29);
            btnGenerateKey.TabIndex = 1;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // tbKey
            // 
            tbKey.Location = new Point(17, 25);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(416, 28);
            tbKey.TabIndex = 0;
            tbKey.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDecrypt);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnEncrypt);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(26, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 208);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose ";
            // 
            // btnDecrypt
            // 
            btnDecrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrypt.Location = new Point(40, 157);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(155, 34);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decryp Message";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnSave
            // 
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(40, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Photo";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnEncrypt.Location = new Point(40, 66);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(155, 34);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt Message";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnOpen
            // 
            btnOpen.ForeColor = SystemColors.ActiveCaptionText;
            btnOpen.Location = new Point(40, 22);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(155, 34);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open Photo";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(242, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbMessage);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(26, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(630, 71);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Enter message ";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(17, 25);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(590, 28);
            tbMessage.TabIndex = 0;
            tbMessage.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(593, 454);
            button2.Name = "button2";
            button2.Size = new Size(63, 38);
            button2.TabIndex = 4;
            button2.Text = "Back ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(690, 504);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnGenerateKey;
        private RichTextBox tbKey;
        private GroupBox groupBox2;
        private Button btnDecrypt;
        private Button btnSave;
        private Button btnEncrypt;
        private Button btnOpen;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private RichTextBox tbMessage;
        private Button button2;
    }
}