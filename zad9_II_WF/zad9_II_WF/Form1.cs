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

namespace zad9_II_WF
{
    public partial class Form1 : Form
    {
        void OutputText(string fileName)
        {
            string currentString = "";
            using(StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    richTextBox1.AppendText($"{currentString}\n");
                }
            }
        }
        public static string ShortestString(string fileName)
        {
            string currentString, shortestString = "";
            int buf = Int32.MaxValue;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length < buf)
                        buf = shortestString.Length;
                    shortestString = currentString;
                }
                return shortestString;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string shortStr = ShortestString("memory.txt");
            int lng = shortStr.Length;
            richTextBox2.AppendText(shortStr);
            richTextBox3.AppendText(lng.ToString());
            OutputText("memory.txt");
        }
    }
}
