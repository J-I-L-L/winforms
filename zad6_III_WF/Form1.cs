using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_III_WF
{
    public partial class Form1 : Form
    {
        StringBuilder matrix = new StringBuilder();
        StringBuilder arif = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string tb1 = textBox1.Text;
            int n = 0;
            n = int.Parse(tb1);
            int[,] A = new int[n, n];
            int sum = 0;
            int denom = 0;
            double res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = r.Next(-10, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n - 1)
                    {
                        sum += A[i, j];
                        denom++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix.AppendLine("a ["+(i+1) +"]["+(j+1)+"] = "+A[i,j]);
                }
            }
            richTextBox1.Text = matrix.ToString();
            res = sum / denom;
            arif.Append(res);
            richTextBox2.Text = arif.ToString();
         }
    }
}
