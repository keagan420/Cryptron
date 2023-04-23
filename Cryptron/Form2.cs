using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptron
{
    public partial class Form2 : Form
    {
        private Bitmap image;
        private byte[] message;
        private byte[] key;

        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();


            mainForm.Show();
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Open a photo and display it in the picture box
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = image;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
              image = (Bitmap)pictureBox1.Image;
              image.Save(saveFileDialog1.FileName);
            }
         }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
        
            key = Guid.NewGuid().ToByteArray();
            tbKey.Text = BitConverter.ToString(key).Replace("-", "");
        }
               

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

           
        }    

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////
            tbMessage.Clear();
            //////////////////////////////////////////////////////

            
        }



    }
}

    




















