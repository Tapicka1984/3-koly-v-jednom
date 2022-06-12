using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text.Contains("  "))
            {
                textBox1.Text.Replace("  ", " ");
            }
            string[] slova = textBox1.Text.Split(' ');
            MazaniCisel(slova);
        }

        public void MazaniCisel(string[] slova)
        {
            listBox1.Items.Clear();
            string newstr = "";
            foreach (string s in slova)
            {
                string s3 = s;
                foreach (char s2 in s3)
                {
                    if (char.IsDigit(s2))
                    {
                        s3 = s3.Replace(s2.ToString(), "");
                    }
                }
                newstr += " " + s3;
                listBox1.Items.Add(s3);
            }
            label1.Text = newstr.Trim();
        }
    }
}
