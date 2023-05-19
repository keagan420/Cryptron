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
        bool gotfile = false;
        Form2 f2 = new Form2();

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
                    MessageBox.Show("Encryption complete");
                }
                else if (RVernam.Checked)
                {
                    string ciphertext = VernamCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
                    isEncryped = true;
                    MessageBox.Show("Encryption complete");
                }
                else if (Transposition.Checked)
                {
                    if ((byte)tbKey.Text.Length == (byte)rtbMessage.Text.Length)
                    {
                        string ciphertext = TranspositionCipher(plaintext, key);
                        rtbMessage.Text = ciphertext;
                        isEncryped = true;
                        MessageBox.Show("Encryption complete");
                    }
                    else
                    {
                        MessageBox.Show("Key length must be equal to message length");
                        MessageBox.Show("Press generate key to get a key that is the same length");
                    }
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
                    MessageBox.Show("Decryption complete");
                }
                else if (RVernam.Checked)
                {
                    string plaintext = VernamCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                    MessageBox.Show("Decryption complete");
                }
                else if (Transposition.Checked)
                {
                    if ((byte)tbKey.Text.Length == (byte)rtbMessage.Text.Length)
                    {
                        string plaintext = TranspositionCipher(ciphertext, key, true);
                        rtbMessage.Text = plaintext;
                        isEncryped = true;
                        MessageBox.Show("Encryption complete");
                    }
                    else
                    {
                        MessageBox.Show("Key length must be equal to message length");
                        MessageBox.Show("Press generate key to get a key that is the same length");
                    }

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
                    MessageBox.Show("File import complete");
                }
                else
                {
                    rtbMessage.Text = inputFile;
                    MessageBox.Show("File import complete");
                }
            }

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {

        }



        private void bttnGenerateKey_Click(object sender, EventArgs e)
        {
            int byteKeyLegth = rtbMessage.Text.Length;
            byte[] length;
            if (Transposition.Checked == true || RVernam.Checked == true)
            { length = new byte[byteKeyLegth]; }

            else
            { length = new byte[32]; }
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

            key = tbKey.Text;
            string output = "";

            int keyLength = key.Length;

            for (int i = 0; i < (keyLength); i++)
            {
                char plain_text = input[i % input.Length];
                char key_text = key[i % key.Length];

                int xor;

                if (decrypt)
                {
                    //MessageBox.Show("Decrypting");
                    string cipherText = rtbMessage.Text;
                    char cipherChar = cipherText[i % cipherText.Length];

                    xor = cipherChar ^ key_text;
                    while (xor < 32 || xor > 126)
                    {
                        xor = xor - 32;
                    }
                    char cipher = (char)xor;
                    char plaintext = (char)xor;
                    output += plaintext;

                }
                else
                {
                    //MessageBox.Show("Encrypting");
                    //XOR the plaintext and the key used for encryption

                    xor = plain_text ^ key_text;

                    while (xor < 32 || xor > 126)
                    {
                        xor = xor + 32;
                    }
                    char cipher = (char)xor;
                    output += cipher;

                }
                
            }
            return output.ToString();
        }

        private string TranspositionCipher(string input, string key, bool decrypt = false)
        {
            if (key.Length == input.Length)
            {

                if (gotfile == true)
                {
                    byte[] inputBytes = (decrypt) ? Convert.FromBase64String(input) : Encoding.UTF8.GetBytes(input);
                    byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                    int blockSize = keyBytes.Length;
                    int blockCount = (int)Math.Ceiling(inputBytes.Length / (double)blockSize);

                    byte[] resultBytes = new byte[inputBytes.Length];

                    if (decrypt)
                    {
                        // Decrypt the input
                        for (int i = 0; i < blockCount; i++)
                        {
                            for (int j = 0; j < blockSize; j++)
                            {
                                int index = j * blockCount + i;
                                if (index < inputBytes.Length)
                                {
                                    resultBytes[index] = inputBytes[i * blockSize + j];
                                }
                            }
                        }
                    }
                    else
                    {
                        // Encrypt the input
                        for (int i = 0; i < blockCount; i++)
                        {
                            for (int j = 0; j < blockSize; j++)
                            {
                                int index = i * blockSize + j;
                                if (index < inputBytes.Length)
                                {
                                    resultBytes[i * blockSize + j] = inputBytes[j * blockCount + i];
                                }
                            }
                        }
                    }

                    string result = (decrypt) ? Encoding.UTF8.GetString(resultBytes) : Convert.ToBase64String(resultBytes);

                    return result;

                }
                else
                {
                    if (decrypt)
                    {
                        int[] keyOrder = Enumerable.Range(0, key.Length).OrderBy(i => key[i]).ToArray();
                        int numRows = (int)Math.Ceiling((double)input.Length / key.Length);
                        char[,] grid = new char[numRows, key.Length];
                        int index = 0;
                        for (int i = 0; i < numRows; i++)
                        {
                            for (int j = 0; j < key.Length; j++)
                            {
                                if (index < input.Length)
                                {
                                    grid[i, j] = input[index];
                                    index++;
                                }
                            }
                        }
                        string encryptedInput = "";
                        for (int i = 0; i < key.Length; i++)
                        {
                            int colIndex = Array.IndexOf(keyOrder, i);
                            for (int j = 0; j < numRows; j++)
                            {
                                if (grid[j, colIndex] != '\0')
                                {
                                    encryptedInput += grid[j, colIndex];
                                }
                            }
                        }
                        return encryptedInput;


                    }
                    else
                    {
                        int[] keyOrder = Enumerable.Range(0, key.Length).OrderBy(i => key[i]).ToArray();
                        int numRows = (int)Math.Ceiling((double)input.Length / key.Length);
                        char[,] grid = new char[numRows, key.Length];
                        int index = 0;
                        for (int i = 0; i < key.Length; i++)
                        {
                            int colIndex = Array.IndexOf(keyOrder, i);
                            for (int j = 0; j < numRows; j++)
                            {
                                if (index < input.Length)
                                {
                                    grid[j, colIndex] = input[index];
                                    index++;
                                }
                            }
                        }
                        string decryptedInput = "";
                        for (int i = 0; i < numRows; i++)
                        {
                            for (int j = 0; j < key.Length; j++)
                            {
                                if (grid[i, j] != '\0')
                                {
                                    decryptedInput += grid[i, j];
                                }
                            }
                        }

                        return decryptedInput;
                    }

                }
            }
            else
            {
                MessageBox.Show("Key must be the same length, press the generate key button.");
                return "";
            }
        }

       
        private void Transposition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbMessage.Clear();
            Clipboard.SetDataObject(tbKey.Text, true);
            MessageBox.Show("Key coppied to clipboard.");

            tbKey.Clear();
        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            if (Transposition.Checked == true || RVigenere.Checked == true)
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

        private void button2_Click(object sender, EventArgs e)
        {

            f2.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void RVigenere_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}