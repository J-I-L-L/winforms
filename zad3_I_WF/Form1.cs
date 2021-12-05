using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3_I_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double func = Math.Pow(x, 3) - Math.Sin(x);
            return func;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = "";
            string tb2 = "";
            double a = 0;
            double aX = 0;
            double b = 0;
            double bX = 0;
            tb1 = textBox1.Text;
            tb2 = textBox2.Text;
            double.TryParse(tb1, out a);
            double.TryParse(tb2, out b);
            aX = f(a);
            bX = f(b);
            if (aX > bX)
            {
                MessageBox.Show("Значение функции больше в точке а.");
            }
            else
            {
                MessageBox.Show("Значение функции выше в точке b.");
            }
        }
    }
}
