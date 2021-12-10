using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_IV_WinForm
{
    public partial class Form1 : Form
    {
        int n;
        int[] X;
        int[][] arr;
        string[] msg, strX;
        public Form1()
        {
            InitializeComponent();
        }
        void Main()
        {
            if (Int32.TryParse(textBox1.Text, out n) && n > 0)
            {
                arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[n];
                }
                X = new int[n];
            }
            else
            {
                MessageBox.Show("Размер квадратной матрицы должен быть целочисленным положительным");
            }
        }

        void secMain()
        {
            richTextBox1.Clear();
            msg = textBox2.Text.Split();//по стандарту делится пробелами
            if (msg.Length == n * n)
            {
                for (int i = 0, k = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (Int32.TryParse(msg[k], out arr[j][i])) { k++; }
                        else
                        {
                            MessageBox.Show($"Какая то проблема в элементе [{i + 1},{j + 1}]");
                        }
                    }
                }
                strX = textBox3.Text.Split();
                if (strX.Length == n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (Int32.TryParse(strX[i], out X[i])) { }
                        else
                        {
                            MessageBox.Show($"Какая то проблема в элементе X:[{i + 1}]");
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {

                        for (int j = 0; j < n; j++)
                        {
                            if ((i + 1) % 2 == 1)
                            {
                                richTextBox1.AppendText(X[j].ToString());
                                richTextBox1.AppendText($" ");
                            }
                            else
                            {
                                richTextBox1.AppendText(arr[j][i].ToString());
                                richTextBox1.AppendText($" ");
                            }
                        }
                        richTextBox1.AppendText("\n");
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели больше, чем задали размер");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели больше, чем задали размер");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secMain();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
