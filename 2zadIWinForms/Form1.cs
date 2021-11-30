using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2zadIWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double x = 0.0;
                double y = 0.0;
                double.TryParse(textBox1.Text, out x);
                double.TryParse(textBox2.Text, out y);
                if (x * x + y * y < 64 && x * x + y * y > 9 && x <= 0)
                {
                MessageBox.Show("Точка находится внути закрашенной области");
                }
                else if (x * x + y * y == 64 || x * x + y * y == 9 && x <= 0)
                {
                MessageBox.Show("Точка находится на границе закрашенной области");
                }
                else
                {
                MessageBox.Show("Точка находится ВНЕ закрашенной области");
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
