using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string forr = "";
        string whille = "";
        string dwhile = "";
        private void button3_Click(object sender, EventArgs e)
        {
            int k = 25;
            for (; k <= 35; k++)
            {
                forr+=k + "  " + (k + 0.5) + "  " + (k - 0.2)+"\n";
                
            }
            MessageBox.Show(forr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 25;
            while (i <= 35)
            {
                whille+=i + "  " + (i + 0.5) + "  " + (i - 0.2)+"\n";
               
                i++;
            }
            MessageBox.Show(whille);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 25;
            do
            {
                dwhile+=j + "  " + (j + 0.5) + "  " + (j - 0.2)+"\n";
                
                j++;
            } while (j <= 35);
            MessageBox.Show(dwhile+"\n");
        }
    }
}
