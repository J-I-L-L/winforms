using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad7_II_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string[] words;
            words = tb1.Split();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (Char.IsDigit(words[i][j]))
                    {
                        for (int z = 0; z < words[i].Length; z++)
                        {
                            if (words[i][z] != ',' || words[i][z] != '?' || words[i][z] != '.' || words[i][z] != '!' || words[i][z] != ';')
                            {
                                richTextBox1.AppendText($"{words[i][z]}");
                            }
                        }
                    }
                }
                richTextBox1.AppendText($" ");
            }
        }
    }

}
