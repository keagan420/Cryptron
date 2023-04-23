using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "TXT Files|*.txt";
            openFileDialog1.Title = "Select a TXT File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                // Load the text file into a RichTextBox
                tbBook.LoadFile(filePath, RichTextBoxStreamType.PlainText);

                // Load the text into a string
                bookText = tbBook.Text;

                // Remove newline characters from the string
                bookText = bookText.Replace("\n", " ");

                // Build the word index map
                int pageIndex = 1;
                int lineIndex = 1;
                int wordIndex = 1;

                foreach (string word in bookText.Split(' '))
                {
                    string indexString = $"{pageIndex}:{lineIndex}:{wordIndex}";

                    if (!wordIndexMap.ContainsKey(word))
                    {
                        wordIndexMap.Add(word, indexString);
                    }
                    else
                    {
                        wordIndexMap[word] += $",{indexString}";
                    }

                    wordIndex++;

                    if (wordIndex > 10)
                    {
                        wordIndex = 1;
                        lineIndex++;
                    }

                    if (lineIndex > 30)
                    {
                        lineIndex = 1;
                        pageIndex++;
                    }
                }

                MessageBox.Show("Book imported successfully!");
            }
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = tbMessage.Text.ToLower();
            StringBuilder ciphertextBuilder = new StringBuilder();

            foreach (string word in plaintext.Split(' '))
            {
                if (wordIndexMap.ContainsKey(word))
                {
                    string[] indices = wordIndexMap[word].Split(',');

                    foreach (string index in indices)
                    {
                        ciphertextBuilder.Append($"{index};");
                    }
                }
                else
                {
                    MessageBox.Show($"Word '{word}' not found in book!");
                    return;
                }
            }

            tbKey.Text = ciphertextBuilder.ToString();
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


























