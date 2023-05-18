using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

        }

        private string GenerateKey()
        {
            //Generate random key based on english alphabet
            int byteKeyLegth = tbMessage.Text.Length;
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
        public static int[] Fibonacci(int start, int nth)
        {
            int number = 0;
            //fibonacci sequence that starts at the position of the start variable and has a length of the nth variable
            int[] seq = new int[nth];
            if(start <= 1)
            {
                seq[0] = 0;
                
            }
            else
            {
                for(int i = 0; i < nth; i++)
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
            if(n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        private static string ReverseConcatenate(string text, string key)
        {
            char[] revKey = key.ToCharArray();
            Array.Reverse(revKey);

            StringBuilder wordbuilder = new StringBuilder();
            for(int j = 0; j < text.Length; j++)
            {
                wordbuilder.Append(text[j]);
               if(j < revKey.Length)
                {
                    wordbuilder.Append(revKey[j]);
                }

            }
            return wordbuilder.ToString();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();


            mainForm.Show();
            this.Close();
        }

       


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int[] fib = new int[tbMessage.Text.Length];
            string plainText = tbMessage.Text;
            string key = GenerateKey();
            string cipherText = ReverseConcatenate(plainText, key);
            
            //MessageBox.Show(key);
            fib = Fibonacci(3, 6);
            /*for(int i = 0; i < fib.Length; i++)
            {
                tbText.Text += fib[i].ToString() + " ";
            }*/
            tbText.Text = "Plain text: " + plainText + "\nKey: " + key +  "\nCipherText before fibonacci cipher:" + cipherText;
            

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}


























