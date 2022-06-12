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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string řetezec = textBox1.Text;
            JeAlfanumericky(řetezec);
        }
        public void JeAlfanumericky(string řetezec)
        {
            int pocetVelkych = 0;
            int pocetMalych = 0;
            int pocetNealfa = 0;
            bool Alfa = false;

            foreach (char x in řetezec)
            {
                if (((x >= 48) && (x <= 57)) || ((x >= 65) && (x <= 90)) || ((x >= 97) && (x <= 122)))
                {
                    if ((x >= 65) && (x <= 90))
                    {
                        pocetVelkych++;
                    }
                    if ((x >= 97) && (x <= 122))
                    {
                        pocetMalych++;
                    }
                }
                else
                {
                    pocetNealfa++;
                    Alfa = true;
                }
            }
            if(Alfa == false)
            {
                MessageBox.Show("Řetezec je Alfanumericky, pocet Velkych je:" + pocetVelkych + "pocet malych je:" + pocetMalych + "pocet Nealfanumerickych je:" + pocetNealfa);
            }
            else
            {
                MessageBox.Show("Řetezec neni Alfanumericky, pocet Velkych je:" + pocetVelkych + "pocet malych je:" + pocetMalych + "pocet Nealfanumerickych je:" + pocetNealfa);
            }
        }
    }
}
