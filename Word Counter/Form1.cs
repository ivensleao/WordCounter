using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Word_Counter
{
    public partial class Form1 : Form
    {
        private List<string> wordList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wordList != null && wordList.Count > 0)
            {
                txtResult.Text = string.Empty;

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                foreach (string word in wordList)
                {
                    if (word.Length >= 3)
                    {
                        if (dictionary.ContainsKey(word))
                        {
                            dictionary[word]++;
                        }
                        else
                        {
                            dictionary[word] = 1;
                        }

                    }  

                }

                var sortedDict = (from entry in dictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

                MessageBox.Show("Aguarde! O processo demorará de acordo com o tamanho do arquivo a ser analisado!");

                foreach (KeyValuePair<string, int> pair in sortedDict)
                {
                    txtResult.Text += pair.Key + "\t  " + pair.Value + " vez(es) \r\n";
                }

                textFile.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Selecione um arquivo!");
            }

            wordList = new List<string>();

            btnClipboard.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnClipboard.Enabled = false;
            
            fileDialog.Filter = "Text Files (.txt)|*.txt";
            fileDialog.FilterIndex = 1;

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnAnalysis.Enabled = true;
                
                string fileName = textFile.Text = fileDialog.FileName;
             
                string inputString = File.ReadAllText(fileName, Encoding.UTF8);

                // Convert our input to lowercase
                inputString = inputString.ToLower();

                Regex emailReplace = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);
                inputString = emailReplace.Replace(inputString, " ");


                // Define characters to strip from the input and do it
                string[] stripChars = { ";", ",", ".", "-", "_", "(", ")", "[", "]", "'",@"""", "::",":",
                                          "?", "!", "+", "*", @"/", @"\", @"#",@"%",">", "<","=", "{", "}",
						"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };
                foreach (string character in stripChars)
                {
                    inputString = inputString.Replace(character, " ");
                }

                this.wordList = inputString.Split(' ').ToList();

                //this.wordList = this.wordList.Distinct().ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("A análise não apresentou resultados");
            }
            else
            {
                System.Windows.Forms.Clipboard.SetText(txtResult.Text);
                MessageBox.Show("Texto copiado!");
            }
        }
    }
}
