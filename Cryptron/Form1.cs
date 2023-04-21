using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System;

namespace Cryptron
{
    public partial class Form1 : Form
    {
        bool isEncryped;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = rtbMessage.Text;
            string key = tbKey.Text;

            if (!string.IsNullOrEmpty(plaintext))
            {
                if (RVigenere.Checked)
                {
                    // string ciphertext = VigenereCipher(plaintext, key);
                    // rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (RVernam.Checked)
                {
                    //string ciphertext = VernamCipher(plaintext, key);
                    //rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (Transposition.Checked)
                {
                    //string ciphertext = TranspositionCipher(plaintext, key);
                    //rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (radioButton4.Checked)
                {
                    //string ciphertext = RandomCipher(plaintext, key);
                    //rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else
                {
                    MessageBox.Show("Please select a cipher");
                }
            }
            else
            {
                MessageBox.Show("Please enter a message or choose a file to encrypt");
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = rtbMessage.Text;
            string key = tbKey.Text;
            if (!string.IsNullOrEmpty(ciphertext))
            {
                if (RVigenere.Checked)
                {
                    string plaintext = VigenereCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                }
                else if (RVernam.Checked)
                {
                    string plaintext = VernamCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                }
                else if (Transposition.Checked)
                {
                    string plaintext = TranspositionCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                }
                else if (radioButton4.Checked)
                {
                    string plaintext = RandomCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                }
                else
                {
                    MessageBox.Show("Please select a cipher");
                }
            }
            else
            {
                MessageBox.Show("Please enter a message or choose a file to decrypt ");
            }


        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            rtbMessage.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to encrypt or decrypt";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog.FileName);
                string inputFile = Convert.ToBase64String(fileData);

                if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                {
                    rtbMessage.Text = System.Text.Encoding.UTF8.GetString(fileData);
                }
                else
                {
                    rtbMessage.Text = inputFile;
                }
            }

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnGenerateKey_Click(object sender, EventArgs e)
        {
            byte[] key = new byte[32];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
            }
            tbKey.Text = Convert.ToBase64String(key);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save encrypted/decrypted file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {

                byte[] fileData;

                if (isEncryped == false)
                {
                    string fileText = rtbMessage.Text;
                    File.WriteAllText(saveFileDialog.FileName, fileText);
                }
                else
                {

                    if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".txt")
                    {
                        fileData = System.Text.Encoding.UTF8.GetBytes(rtbMessage.Text);
                    }
                    else
                    {
                        fileData = Convert.FromBase64String(rtbMessage.Text);
                    }

                    File.WriteAllBytes(saveFileDialog.FileName, fileData);
                }
            }
        }

        private string VigenereCipher(string input, string key, bool decrypt = false)
        {
            return null;
        }

        private string VernamCipher(string input, string key, bool decrypt = false)
        {
            return null;
        }

        private string TranspositionCipher(string input, string key, bool decrypt = false)
        {
            return null;
        }

        private string RandomCipher(string input, string key, bool decrypt = false)
        {
            return null;
        }

        private void Transposition_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}