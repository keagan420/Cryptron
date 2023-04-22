using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    string ciphertext = VigenereCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (RVernam.Checked)
                {
                    string ciphertext = VernamCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (Transposition.Checked)
                {
                    string ciphertext = TranspositionCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
                    isEncryped = true;
                }
                else if (radioButton4.Checked)
                {
                    string ciphertext = RandomCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
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
            MessageBox.Show("Encryption complete");

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
            byte[] length = new byte[32];
            const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new RNGCryptoServiceProvider();

            random.GetBytes(length);
            var key = new StringBuilder();
            foreach (var b in length)
            {
                int index = b % alphabet.Length;
                key.Append(alphabet[index]);
            }
            tbKey.Text = key.ToString();
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
            MessageBox.Show("File saved.");
        }

        private static string VigenereCipher(string input, string key, bool decrypt = false)
        {
            string output = "";
            int keyIndex = 0;
            int keyLength = key.Length;
            int inputLength = input.Length;
            int[] keyValues = new int[keyLength];

            for (int i = 0; i < keyLength; i++)
            {
                char keyChar = key[i];
                if (Char.IsUpper(keyChar))
                {
                    keyValues[i] = ((int)keyChar) - 65;
                }
                else if (Char.IsLower(keyChar))
                {
                    keyValues[i] = ((int)keyChar) - 97;
                }
                else
                {
                    // Key character is not a letter, so skip it
                    keyLength++;
                }
            }

            for (int i = 0; i < inputLength; i++)
            {
                char inputChar = input[i];
                if (Char.IsUpper(inputChar))
                {
                    if (decrypt)
                    {
                        int decryptedValue = (((int)inputChar) - 65 - keyValues[keyIndex] + 26) % 26;
                        output += (char)(decryptedValue + 65);
                    }
                    else
                    {
                        int encryptedValue = (((int)inputChar) - 65 + keyValues[keyIndex]) % 26;
                        output += (char)(encryptedValue + 65);
                    }
                    keyIndex = (keyIndex + 1) % keyLength;
                }
                else if (Char.IsLower(inputChar))
                {
                    if (decrypt)
                    {
                        int decryptedValue = (((int)inputChar) - 97 - keyValues[keyIndex] + 26) % 26;
                        output += (char)(decryptedValue + 97);
                    }
                    else
                    {
                        int encryptedValue = (((int)inputChar) - 97 + keyValues[keyIndex]) % 26;
                        output += (char)(encryptedValue + 97);
                    }
                    keyIndex = (keyIndex + 1) % keyLength;
                }
                else
                {
                    output += inputChar;
                }
            }

            return output;
        }



        private string VernamCipher(string input, string key, bool decrypt = false)
        {
            /*This cipher uses a key to XOR it with the plain text*/
            int inputLength = input.Length;
            
            //Generate key
            
            var random = RandomNumberGenerator.Create();
            var bytes = new byte[(input.Length)];
            random.GetBytes(bytes);
            string mykey = "";
            mykey = Encoding.ASCII.GetString(bytes);
            key = mykey;
            MessageBox.Show(key);

            //have an array for key
            string output = "";
            int keyIndex = 0;
            int keyLength = key.Length;
            
            int[] keyValues = new int[keyLength];
            
            
            
             
            for (int i = 0; i < keyLength; i++)
            {
                char plain_text = input[i];
                char key_text = key[i % key.Length];
                char[] cipher_text = input.ToCharArray();
                int xor;
                if (decrypt)
                {
                    //XOR the ciphertext and the same key used for encryption
                    for (int j = 0; j < cipher_text.Length; j++)
                    {
                        output = "";
                        int encryptedCode = (int)j;
                        //MessageBox.Show(output.ToString());
                        char text = cipher_text[j];
                        xor = text ^ key_text;
                        if (xor < 65 || xor > 126)
                        {
                            xor = xor + 65;
                        }
                        char decrypted = (char)(xor);
                        output += decrypted;
                    }
                    //return output;
                            
                    
                }
                else
                {
                    //XOR the plaintext and the key used for encryption
                    //XORed values have to be within the range of 65 and 126
                    xor = plain_text ^ key_text;
                    while (xor < 65 || xor > 126)
                    {
                        /*This while loop checks if the result from the
                         xor is outside of the 65 - 126 range of ascii values
                        if it is outside, 65 will be subtracted from xor*/
                        xor = xor - 65;
                    }
                    char plaintext = (char)xor;
                    output += plaintext;
                    cipher_text[i] = plaintext;
                    //return output.ToString();
                }


               
            }
            return output.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            rtbMessage.Clear();
            Clipboard.SetDataObject(tbKey.Text, true);
            MessageBox.Show("Key coppied to clipboard." );
            
            tbKey.Clear();
        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            string input = tbKey.Text;
            bool isAlpha = input.All(c => Char.IsLetter(c));
            if (!isAlpha) 
            {
                MessageBox.Show("Please only enter alphabetical characters");
                int cursorPosition = tbKey.SelectionStart;
                tbKey.Text = tbKey.Text.Remove(cursorPosition - 1, 1);
                tbKey.SelectionStart = cursorPosition - 1;
                tbKey.SelectionLength = 0;
            }
        }
    }
}