using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad12_WinForms
{
    
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int bufA = 0;
        int bufB = 0;
        public Form1()
        {
            InitializeComponent();
        }
        class Rectangle
        {
            int a, b;
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public void OutputInfo()
            {
                Console.WriteLine("Периметр =\t" + Perimetr());
                Console.WriteLine("Площадь =\t" + Ploshad());
            }
            public int Perimetr()
            {
                return a + a + b + b;
            }
            public int Ploshad()
            {
                return a * b;
            }
            public int A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }
            public int B
            {
                get
                {
                    return b;
                }
                set
                {
                    b = value;
                }
            }
            public int this[int index]
            {
                get
                {
                    if (index == 0) return A;
                    if (index == 1) return B;
                    else
                    {
                        MessageBox.Show("Введён неверный индекс!");
                        return 0;
                    }
                }
            }
            public bool SquareCheck
            {
                get
                {
                    if (a == b)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            public static Rectangle operator ++(Rectangle side) => new Rectangle(++side.a, ++side.b);

            public static Rectangle operator --(Rectangle side) => new Rectangle(--side.a, --side.b);

            public static bool operator true(Rectangle side) => side.SquareCheck;
            public static bool operator false(Rectangle side) => side.SquareCheck;

            public static Rectangle operator *(Rectangle side, int scl) => new Rectangle(side.a = side.a * scl, side.b = side.b * scl);

            public static explicit operator string(Rectangle side)
            {
                return ($"{side.a.ToString()} {side.b.ToString()}");
            }

            public static explicit operator Rectangle(string str)
            {
                string[] buf = str.Split(" ");
                Rectangle retBuf = new Rectangle(Convert.ToInt32(buf[0]), Convert.ToInt32(buf[1]));
                return retBuf;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            Rectangle rec = new Rectangle(a, b);
            int per = rec.Perimetr();
            int pls = rec.Ploshad();
            richTextBox1.AppendText($"Периметр {per}\n");
            richTextBox1.AppendText($"Площадь: {pls}\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            Rectangle rec = new Rectangle(a, b);
            ++rec;
            int per = rec.Perimetr();
            int pls = rec.Ploshad();
            richTextBox1.AppendText("Данные после использования перегруженного ++:\n");
            richTextBox1.AppendText($"Периметр {per}\n");
            richTextBox1.AppendText($"Площадь: {pls}\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            Rectangle rec = new Rectangle(a, b);
            --rec;
            int per = rec.Perimetr();
            int pls = rec.Ploshad();
            richTextBox1.AppendText("Данные после использования перегруженного --:\n");
            richTextBox1.AppendText($"Периметр {per}\n");
            richTextBox1.AppendText($"Площадь: {pls}\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            Rectangle rec = new Rectangle(a, b);
            if (rec)
            {
                richTextBox1.AppendText("Фигура является квадратом\n");
            }
            else
            {
                richTextBox1.AppendText("Фигура не является квадратом\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int scl;
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            int.TryParse(tb1, out a);
            int.TryParse(tb2, out b);
            int.TryParse(tb3, out scl);
            Rectangle rec = new Rectangle(a, b);
            rec *= scl;
            int per = rec.Perimetr();
            int pls = rec.Ploshad();
            richTextBox1.AppendText("Данные после использования перегруженного *:\n");
            richTextBox1.AppendText($"Периметр {per}\n");
            richTextBox1.AppendText($"Площадь: {pls}\n");
        }
    }
}
