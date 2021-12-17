using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace zad8_I_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string[] words;
            words = tb1.Split(' ', '.', ',', '?', '!', ':', ';');
            Regex reg = new Regex(@"[А-Я]\S*");
            foreach (var i in words)
            {
                if (reg.IsMatch(i))
                {
                    richTextBox1.AppendText($"{reg.Match(i).ToString()}\n");//Яша играл с Олей, но потом Они разошлись... увы, но Жизнь Жестока!
                }
            }
        }
    }
}
