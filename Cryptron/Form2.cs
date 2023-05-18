using System;
using System.Collections.Generic;
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
        private string bookText = "";
        private Dictionary<string, string> wordIndexMap = new Dictionary<string, string>();
        string word = "";

        //fibonacci sequence
        void Fibonacci(int start, int nth)
        {
            //fibonacci seqence starting from start and ending at nth
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = (start - 1); i < nth; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (i >= start)
                {
                    tbText.Text += c + " ";
                }
            }

        }
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

        private void btnOpen_Click(object sender, EventArgs e)//butto
        {


        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Fibonacci(3, 6);
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
    }


}


























