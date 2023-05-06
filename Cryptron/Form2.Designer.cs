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
            tbMessage = new RichTextBox();
            tbKey = new RichTextBox();
            groupBox2 = new GroupBox();
            tbBook = new RichTextBox();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            btnOpen = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label1.Size = new Size(602, 50);
            label1.TabIndex = 1;
            label1.Text = "CRYPTRON BOOK CIPHER";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMessage);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(26, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter message";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(18, 22);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(590, 28);
            tbMessage.TabIndex = 0;
            tbMessage.Text = "";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(18, 22);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(590, 30);
            tbKey.TabIndex = 0;
            tbKey.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbBook);
            groupBox2.Controls.Add(btnDecrypt);
            groupBox2.Controls.Add(btnEncrypt);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(26, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 196);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose ";
            // 
            // tbBook
            // 
            tbBook.Location = new Point(210, 26);
            tbBook.Name = "tbBook";
            tbBook.Size = new Size(398, 153);
            tbBook.TabIndex = 6;
            tbBook.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrypt.Location = new Point(40, 134);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(155, 46);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decryp Message";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnEncrypt.Location = new Point(40, 78);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(155, 50);
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
            btnOpen.Size = new Size(155, 50);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open book";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbKey);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(26, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(630, 71);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ciphertext";
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
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox tbKey;
        private GroupBox groupBox2;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnOpen;
        private GroupBox groupBox3;
        private RichTextBox tbMessage;
        private Button button2;
        private RichTextBox tbBook;
    }
}