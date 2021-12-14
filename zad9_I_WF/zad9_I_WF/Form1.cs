using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zad9_I_WF
{
    public partial class Form1 : Form
    {
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            int n = int.Parse(tb1);
            FileStream f = new FileStream("fib.dat", FileMode.OpenOrCreate);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
            {
                fOut.Write(Fibonachi(i));
            }
            fOut.Close();
            f = new FileStream("fib.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (int i = 0; i < m; i += 4)
            {
                f.Seek(i, SeekOrigin.Begin);
                int hlam = i / 4 + 1;
                if (hlam % 3 != 0 || i == 0)
                {
                    int a = fIn.ReadInt32();

                    richTextBox1.AppendText($"{a} ");
                }
            }
            fIn.Close();
            f.Close();
        }
    }
}
