using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_I_b_WF
{
    public partial class Form1 : Form
    {
        StringBuilder bazze = new StringBuilder();
        StringBuilder result = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            string num_b = textBox2.Text;
            int numb = int.Parse(num);
            int numb_b = int.Parse(num_b);
            string[] tb = textBox3.Text.Split(' ');
            int[,] arr = new int[numb, numb_b];
            int numerator = 0;
            for (int i = 0; i < numb; i++)
             {
                    for (int j = 0; j < numb_b; j++)
                    {
                        int.TryParse(tb[numerator], out arr[i, j]);
                        numerator++;
                        bazze.Append(arr[i,j] + " ");

                        if (arr[i,j] < 0 && arr[i,j] % 3 != 0)
                        {
                            arr[i,j] = -arr[i,j];
                            result.Append(arr[i,j] + " ");
                        }
                        else
                        {
                            result.Append(arr[i,j] + " ");
                        }
                    }
             }
                richTextBox1.Text = bazze.ToString();
                richTextBox2.Text = result.ToString();
        }
    }
}
