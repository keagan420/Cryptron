using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Cryptron
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            tbPlainText.Focus();

        }

        private string GenerateKey()
        {
            //Generate random key based on english alphabet
            int byteKeyLegth = tbPlainText.Text.Length;
            byte[] length;
            length = new byte[byteKeyLegth];
            const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new RNGCryptoServiceProvider();

            random.GetBytes(length);
            var key = new StringBuilder();
            foreach (var b in length)
            {
                int index = b % alphabet.Length;
                key.Append(alphabet[index]);
            }
            return key.ToString();
        }

        //fibonacci sequence
        public static int[] Fibonacci(int nth, int start = 1)
        {
            int number = 0;
            //fibonacci sequence that starts at the position of the start variable and has a length of the nth variable
            int[] seq = new int[nth];
            if (start <= 1)
            {
                seq[0] = 0;

            }
            else
            {
                for (int i = 0; i < nth; i++)
                {
                    number = Fib(start - 1) + Fib(start - 2);
                    start++;
                    seq[i] = number;

                }
            }
            return seq;
        }
        private static int Fib(int n) //recursive fibonacci sequence
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        private static string ReverseConcatenate(string text, string key)
        {//This method reverses the key and concatenates it to the text.

            char[] revKey = key.ToCharArray();
            Array.Reverse(revKey);

            StringBuilder wordbuilder = new StringBuilder();
            for (int j = 0; j < text.Length; j++)
            {
                wordbuilder.Append(text[j]);
                if (j < revKey.Length)
                {
                    wordbuilder.Append(revKey[j]);
                }

            }
            return wordbuilder.ToString();

        }

        private static string Fib_cipher_encrypt(string txt, string key)
        {
            //shift the reversed concatenated text by the fibonacci sequence
            int txtLength = txt.Length;
            int[] sequence = new int[txtLength];
            string revConcat = ReverseConcatenate(txt, key);
            int revConcatLength = revConcat.Length;
            sequence = Fibonacci(revConcatLength);
            string result = "";


            for (int i = 0; i < revConcatLength; i++)
            {

                int char_val = (int)revConcat[i];
                char character = revConcat[i];
                int num = sequence[i];
                if (Char.IsLetter(character))
                {
                    if (Char.IsUpper(character))
                    {
                        result += (char)(((char_val + num - 65 + 26) % 26) + 65);
                    }
                    else
                    {
                        result += (char)(((char_val + num - 97 + 26) % 26) + 97);
                    }

                }
                else
                {
                    if (character == ' ')
                    {
                        result += ' ';
                        continue;
                    }
                    else if (Char.IsDigit(character))
                    {
                        result += (char)(((char_val + num - 48 + 10) % 10) + 48);
                    }



                    else
                    {
                        continue;
                    }
                }


            }
            return result;
        }

        private string Fib_cipher_decrypt(string cipher_text)
        {
            string result = "";
            int cipherLen = cipher_text.Length;
            int[] sequence = Fibonacci(cipherLen);

            for (int i = 0; i < cipherLen; i++)
            {
                int char_val = (int)cipher_text[i];
                char character = cipher_text[i];
                int num = sequence[i];


                if (Char.IsLetter(character))
                {
                    if (Char.IsUpper(character))
                    {
                        result += (char)(((char_val - num - 65 + 26) % 26) + 65);
                    }
                    else
                    {
                        result += (char)(((char_val - num - 97 + 26) % 26) + 97);
                    }

                }
                else
                {
                    if (character == ' ')
                    {
                        result += ' ';
                        continue;
                    }
                    else if (Char.IsDigit(character))
                    {
                        result += (char)(((char_val + num - 48 + 10) % 10) + 48);
                    }
                    {
                        continue;
                    }
                }

            }
            return result;

        }

        private string reverseSplit(string reversedText)
        {
            string text = "";
            string key = "";

            int textLength = reversedText.Length;

            for (int i = 0; i < textLength; i++)
            {
                if (i % 2 == 0)
                {
                    text += reversedText[i];
                }
                else
                {
                    key += reversedText[i];
                }

            }


            return (text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();


            mainForm.Show();
            this.Close();
        }




        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int inputLength = tbPlainText.Text.Length;
            int[] fib = new int[inputLength];
            //int n = int.Parse(tbStart.Text);
            string plainText = tbPlainText.Text;
            string key = tbKey.Text;
            string rev_text = ReverseConcatenate(plainText, key);
            string cipherText = Fib_cipher_encrypt(plainText, key);

            tbText.Text = "Plain text: " + plainText + "\nCipherText before fibonacci cipher:" + rev_text +
                "\nCipher text after fibonacci: " + cipherText;
            tbCiphertext.Text = cipherText;
            MessageBox.Show("Encryption complete!");

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //int start = int.Parse(tbStart.Text);
            string cipherText = tbCiphertext.Text;

            string partial_plainText = Fib_cipher_decrypt(cipherText);
            tbText.Clear();
            string plain_text = reverseSplit(partial_plainText);
            tbText.Text = "Partial Decrypted Text: " + partial_plainText + "\nDecrypted Text: " + plain_text;


        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            tbKey.Text = GenerateKey();


        }


        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to encrypt or decrypt";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog.FileName);
                string inputFile = Convert.ToBase64String(fileData);

                if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                {
                    tbText.Text = System.Text.Encoding.UTF8.GetString(fileData);
                    MessageBox.Show("File import complete");
                }
                else
                {
                    tbText.Text = inputFile;
                    MessageBox.Show("File import complete");
                }

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save encrypted/decrypted file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {

                byte[] fileData;
                

                if (false)
                {
                    string fileText = tbText.Text;
                    File.WriteAllText(saveFileDialog.FileName, fileText);
                }
                else
                {

                    if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".txt")
                    {
                        fileData = System.Text.Encoding.UTF8.GetBytes(tbText.Text);
                    }
                    else
                    {
                        fileData = Convert.FromBase64String(tbText.Text);
                    }

                    File.WriteAllBytes(saveFileDialog.FileName, fileData);
                }
            }
            MessageBox.Show("File saved.");

        }
    }

}



























