using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestStach12012022
{
    public partial class Stach : Form
    {
        public Stach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonvysledek_Click(object sender, EventArgs e)
        {
            try {
                double cislojedna = double.Parse(textBox1.Text);
                double cislodva = double.Parse(textBox2.Text);
                vysledektext.Text = "";
                if (comboBox1.Text == "+" )
                {
                    double vysledek = cislojedna + cislodva;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "-")
                {
                    double vysledek = cislojedna - cislodva;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "*")
                {
                    double vysledek = cislojedna * cislodva;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "/")
                {
                    if(cislodva == 0 )
                    {
                        MessageBox.Show("Nelze delit nulou!", "Upozorneni");
                    }
                    double vysledek = cislojedna / cislodva;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "%")
                {
                    if (cislodva == 0)
                    {
                        MessageBox.Show("Nelze delit nulou!", "Upozorneni");
                    }
                    double vysledek = cislojedna % cislodva;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "x²")
                {
                    
                    double vysledek = cislojedna *cislojedna;
                    vysledektext.Text += vysledek;
                }
                if (comboBox1.Text == "odmocnina")
                {
                    
                    double vysledek = Math.Sqrt(cislojedna);
                    vysledektext.Text += vysledek;
                }

            }
            catch
            {
                MessageBox.Show("Zadavej jen cisla");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label2.Visible = true;
            textBox2.Text += "";
            if (comboBox1.Text == "x²")
            {
                textBox2.Text += 0;
                label2.Visible = false;
                textBox2.Visible = false;
            }
            if (comboBox1.Text == "odmocnina")
            {
                textBox2.Text += 0;
                label2.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void buttonkonec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsmazat_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            vysledektext.Text = "";
        }
    }
}
