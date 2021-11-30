using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1IWinForms
{
    public partial class Form1 : Form
    {
       

        void show()
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tb1 = textBox1.Text.Split(' ');
            double[] arr = new double[tb1.Length];
            double[] numbers = new double[tb1.Length];
            int znam = numbers.Length;
            double completeSumm = 0.0;
            double average = 0.0;
            for (int i = 0; i < tb1.Length; i++)
            {
                if (Double.TryParse(tb1[i], out arr[i]))
                {
                    numbers[i] = Math.Pow(arr[i], 3);
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные, попробуйте снова.");
                }

            }
            for (int i=0; i<numbers.Length; i++)
            {
                completeSumm += numbers[i];
            }
            average = completeSumm / znam;
            string st=average.ToString();
            MessageBox.Show("Среднее арифметическое кубов данных чисел: "+st);
        }

       
    }
}
