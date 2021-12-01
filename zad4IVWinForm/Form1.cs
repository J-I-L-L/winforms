using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4IVWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string str = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 4; i <= 7; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    
                    str+=" " + i + j + " ";
                }
              
                str+=" " + (i + 1) + "0\n";
            }
            MessageBox.Show(str);
        }
    }
}
