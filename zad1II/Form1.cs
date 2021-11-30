using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1II
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
            string tb2 = textBox2.Text;
            string st;
            int M=0;
            int N=0;
            int.TryParse(tb1, out M);
            int.TryParse(tb2, out N);
            int chastnoe = M / N;
            st =chastnoe.ToString();
            if (M % N == 0)
            {
                MessageBox.Show("\n\nЧастное деления M и N:"+st);
            }
            else
            {
                MessageBox.Show("\n\nM на N нацело не делится! Проверьте введённые числа!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
