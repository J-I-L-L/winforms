using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4_II_WF
{
    public partial class Form1 : Form
    {
        StringBuilder result = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        public void output(int n)
        {
            if (n == 1)
            {
                result.Append(n);
                result.Append(" ");

            }
            else
            {
                output(n - 1);
                result.Append(n);
                result.Append(" ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = "";
            tb1 = textBox1.Text;
            int n = 0;
            Int32.TryParse(tb1, out n);
            if (n < 1000)
            {
                MessageBox.Show("n<1000. Введите другое значение!");
            }
            else
            {
      //          for(int i=1; i<=n; i++)
           //     {
                    output(n);
           //     }
                richTextBox1.Text = result.ToString();
            }
        }
    }
}
