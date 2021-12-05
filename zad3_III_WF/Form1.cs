using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3_III_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x, out double y)
        {
            y = 0;
            //double y = 0;
            if (x >= 0.9)
            {
                y = 1 / ((0.1 + x) * (0.1 + x));
            }
            else if (x >= 0 && x <= 0.9)
            {
                y = 0.2 * x + 0.1;
            }
            else if (x < 0)
            {
                y = x * x + 0.2;
            }
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double otv = 0;
            double a = 0;
            string tb1 = "";
            double b = 0;
            string tb2 = "";
            double h = 0;
            string tb3 = "";
            tb1 = textBox1.Text;
            tb2 = textBox2.Text;
            tb3 = textBox3.Text;
            double.TryParse(tb1, out a);
            double.TryParse(tb2, out b);
            double.TryParse(tb3, out h);
            for (double i = a; i <= b;)
            {
                f(i, out otv);
                MessageBox.Show("Результат функции для [" + i + "] = " + otv);
                i = i + h;
            }
        }
    }
}