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
                else if (radioButton4.Checked)
                {
                    string ciphertext = RandomCipher(plaintext, key);
                    rtbMessage.Text = ciphertext;
                    isEncryped = true;
                    MessageBox.Show("Encryption complete");
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
                else if (radioButton4.Checked)
                {
                    string plaintext = RandomCipher(ciphertext, key, true);
                    rtbMessage.Text = plaintext;
                    isEncryped = true;
                    MessageBox.Show("Decryption complete");
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
            if (Transposition.Checked == true)
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

        private string RandomCipher(string input, string key, bool decrypt = false)
        {
            /// This is a Ceasar cipher that uses a random key///

            int shift = key.ToUpper().ToCharArray()[0] - 'A'; // calculate the shift value based on the key
            if (decrypt) shift = -shift; // if decrypting, invert the shift value
            char[] inputChars = input.ToCharArray();

            for (int i = 0; i < inputChars.Length; i++)
            {
                char c = inputChars[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a'; // calculate the ASCII offset for the case of the letter
                    int shifted = (c - offset + shift) % 26; // apply the shift value and wrap around if needed
                    if (shifted < 0) shifted += 26; // if the result is negative, add 26 to wrap around again
                    inputChars[i] = (char)(shifted + offset); // convert back to ASCII character
                }
            }

            return new string(inputChars); // return the modified string
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
    }
}