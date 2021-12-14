using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad7_I_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char x = char.Parse(textBox2.Text);
                char y = char.Parse(textBox3.Text);

                int count=0;

                foreach (var word in textBox1.Text.ToLower().Split(' '))
                {

                    foreach (var letter in word)
                    {
                        if (letter == x || letter == y)
                        {
                            count++;
                        }
                    }
                }

                richTextBox1.Text = count.ToString();
            }
            catch
            {
                richTextBox1.Text="Incorrect input";
            }
        }
    }
}
