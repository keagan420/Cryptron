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


        //fibonacci sequence
        public static int[] Fibonacci(int start, int nth)
        {
            //fibonacci sequence that starts at the position of the start variable and has a length of the nth variable
            int[] seq = new int[nth];
            if (start <= 1)
            {
                seq[0] = 0;
                seq[1] = 1;
            }
            else
            {
                seq[0] = start;
                seq[1] = start + 1;
            }
            for (int i = 2; i < nth; i++)
            {
                seq[i] = seq[i - 1] + seq[i - 2];
                
            }
            return seq;
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
            fib = Fibonacci(3, 6);
            for(int i = 0; i < fib.Length; i++)
            {
                tbText.Text += fib[i].ToString() + " ";
            }
            //tbText.Text = fib[0].ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            ;
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
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
            MessageBox.Show(key.ToString());

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}


























