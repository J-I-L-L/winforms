using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte num = 0;
            byte.TryParse(textBox1.Text, out num);
            switch (num)
            {
                case 1: MessageBox.Show("Пики"); break;
                case 2: MessageBox.Show("Трефы"); break;
                case 3: MessageBox.Show("Бубны"); break;
                case 4: MessageBox.Show("Червы"); break;
                default: MessageBox.Show("Неверное число! Попробуйте ещё раз"); break;
            }
        }
    }
}
