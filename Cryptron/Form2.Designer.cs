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
            btnGenerateKey = new Button();
            tbText = new RichTextBox();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            tbStart = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(711, 126);
            label1.TabIndex = 1;
            label1.Text = "CRYPTRON FIBONACCI \r\nCIPHER";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMessage);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(33, 156);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(505, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter message";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(21, 29);
            tbMessage.Margin = new Padding(3, 4, 3, 4);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(448, 52);
            tbMessage.TabIndex = 0;
            tbMessage.Text = "";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(21, 29);
            tbKey.Margin = new Padding(3, 4, 3, 4);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(674, 39);
            tbKey.TabIndex = 0;
            tbKey.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGenerateKey);
            groupBox2.Controls.Add(tbText);
            groupBox2.Controls.Add(btnDecrypt);
            groupBox2.Controls.Add(btnEncrypt);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(33, 317);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(779, 292);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose ";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateKey.Location = new Point(46, 28);
            btnGenerateKey.Margin = new Padding(3, 4, 3, 4);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(177, 67);
            btnGenerateKey.TabIndex = 7;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // tbText
            // 
            tbText.Location = new Point(240, 35);
            tbText.Margin = new Padding(3, 4, 3, 4);
            tbText.Name = "tbText";
            tbText.Size = new Size(454, 203);
            tbText.TabIndex = 6;
            tbText.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrypt.Location = new Point(46, 179);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(177, 61);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt Message";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnEncrypt.Location = new Point(46, 104);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(177, 67);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt Message";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbKey);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(33, 634);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(779, 85);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ciphertext";
            // 
            // button2
            // 
            button2.Location = new Point(834, 693);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(72, 51);
            button2.TabIndex = 4;
            button2.Text = "Back ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbStart);
            groupBox4.ForeColor = SystemColors.ButtonFace;
            groupBox4.Location = new Point(624, 156);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(188, 112);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Starting position";
            // 
            // tbStart
            // 
            tbStart.Location = new Point(32, 29);
            tbStart.Margin = new Padding(3, 4, 3, 4);
            tbStart.Name = "tbStart";
            tbStart.Size = new Size(117, 52);
            tbStart.TabIndex = 0;
            tbStart.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1075, 757);
            Controls.Add(groupBox4);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox3;
        private RichTextBox tbMessage;
        private Button button2;
        private RichTextBox tbText;
        private GroupBox groupBox4;
        private RichTextBox tbStart;
        private Button btnGenerateKey;
    }
}