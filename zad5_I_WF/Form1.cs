using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_I_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder result = new StringBuilder();

        static double f(double x)
        {
            try
            {
                if (x == 0)
                {
                    throw new Exception();
                }
                else
                {
                    return Math.Sqrt(x * x - 1);
                }
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = "";
            double a = 0;
            string tb2 = "";
            double b = 0;
            string tb3 = "";
            double h = 0;
            try
            {
                tb1 = textBox1.Text;
                tb2 = textBox2.Text;
                tb3 = textBox3.Text;
                a = double.Parse(tb1);
                b = double.Parse(tb2);
                h = double.Parse(tb3);
                for (double i=a; i<=b; i=i+h)
                {
                    try
                    {
                        result.Append("y ["+ i + "] = "+f(i)+"\n");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка! Возможно в вычислении присутствует ноль и/или неверное число. Убираем лишнее...");
                    }
                    richTextBox1.Text = result.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Введено неверное значение!");
            }
        }
    }
}
