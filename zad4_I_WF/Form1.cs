using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4_I_WF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int nod(int a, int b)
        {

            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b - a);
            }
    }

    private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            int a = 0;
            int b = 0;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            if(a==0 || b == 0)
            {
                MessageBox.Show("Среди чисел есть 0. Попробуйте ввести другие значения");
            }
            else
            {
                MessageBox.Show("НОД двух введённых чисел равен:" + nod(Math.Abs(a), Math.Abs(b)));

            }
        }

    }
}
