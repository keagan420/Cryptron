using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Cryptron
{
    public partial class Form2 : Form
    {
        private string bookText = "";
        private Dictionary<string, string> wordIndexMap = new Dictionary<string, string>();


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
            //Generate a random key for the cipher
            var random = RandomNumberGenerator.Create();
            string text = tbMessage.Text;
            var bytes = new byte[(text.Length)];
            random.GetBytes(bytes);
            string mykey = "";
            mykey = Encoding.ASCII.GetString(bytes);
            //tbKey.Text = mykey;

        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbMessage.Clear();
            string ciphertext = tbKey.Text.ToLower();
            StringBuilder plaintextBuilder = new StringBuilder();

            foreach (string index in ciphertext.Split(';'))
            {
                if (index != "")
                {
                    string[] parts = index.Split(':');
                    int pageIndex = int.Parse(parts[0]);
                    int lineIndex = int.Parse(parts[1]);
                    int wordIndex = int.Parse(parts[2]);

                    string[] words = bookText.Split(' ');
                    int wordCount = (pageIndex - 1) * 300 + (lineIndex - 1) * 10 + wordIndex;

                    if (wordCount <= words.Length)
                    {
                        string word = words[wordCount - 1];
                        plaintextBuilder.Append($"{word} ");
                    }
                    else
                    {
                        MessageBox.Show($"Invalid index {index} in ciphertext!");
                        return;
                    }
                }
            }

            tbMessage.Text = plaintextBuilder.ToString();
        }
    }


}


























