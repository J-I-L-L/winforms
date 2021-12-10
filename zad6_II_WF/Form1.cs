using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_II_WF
{
    public partial class Form1 : Form
    {
        StringBuilder bazze = new StringBuilder();
        StringBuilder result = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        static int Min(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; ++i)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            int numb = int.Parse(num);
            string[] tb = textBox2.Text.Split(' ');
            if (numb >= tb.Length)
            {
                int[] arr = new int[tb.Length];
                int[] final = new int[tb.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    int.TryParse(tb[i], out arr[i]);
                    int min = Min(arr);
                    bazze.Append(arr[i] + " ");
                    if (arr[i]==min)
                    {
                        arr[i] = -arr[i];
                        result.Append(arr[i] + " ");
                    }
                    else
                    {
                        result.Append(arr[i] + " ");
                    }
                }
                richTextBox1.Text = bazze.ToString();
                richTextBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Вы ввели слишком много чисел!");
            }
        }
    }
}
