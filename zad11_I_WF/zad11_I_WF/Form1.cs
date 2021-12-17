using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad11_I_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int bufA = 0;
        int bufB = 0;
        bool pressed = false;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;

               int.TryParse(tb1, out a);
               int.TryParse(tb2, out b);
                int per = (a + b)*2;
                int plosh = a * b;
                richTextBox1.AppendText($"Периметр прямоугольника: {per}\n");
                richTextBox1.AppendText($"Площадь прямоугольника: {plosh}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (pressed)
            {
                if (bufA == bufB)
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("Да");
                }
                else
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("Нет");
                }
            }
            else
            {
                if (a == b)
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("Да");
                }
                else
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("Нет");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pressed = true;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            int.TryParse(tb3, out bufA);
            int.TryParse(tb4, out bufB);
            int newPer = (bufA + bufB) * 2;
            int newPlosh = bufA * bufB;
            richTextBox1.AppendText("\n\nНовая информация:\n");
            richTextBox1.AppendText($"Периметр: {newPer}\n");
            richTextBox1.AppendText($"Площадь: {newPlosh}");
        }
    }
}
