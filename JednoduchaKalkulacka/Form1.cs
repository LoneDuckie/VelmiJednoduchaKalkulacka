using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JednoduchaKalkulacka
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c;
        private void RBplus_Click(object sender, EventArgs e)
        {
            RBplus.Checked = true;
            RBminus.Checked = false;
            RBkrat.Checked = false;
            RBdeleno.Checked = false;
        }

        private void RBminus_Click(object sender, EventArgs e)
        {
            RBplus.Checked = false;
            RBminus.Checked = true;
            RBkrat.Checked = false;
            RBdeleno.Checked = false;
        }

        private void RBkrat_Click(object sender, EventArgs e)
        {
            RBplus.Checked = false;
            RBminus.Checked = false;
            RBkrat.Checked = true;
            RBdeleno.Checked = false;
        }

        private void RBdeleno_Click(object sender, EventArgs e)
        {
            RBplus.Checked = false;
            RBminus.Checked = false;
            RBkrat.Checked = false;
            RBdeleno.Checked = true;
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            RBplus.Checked = false;
            RBminus.Checked = false;
            RBkrat.Checked = false;
            RBdeleno.Checked = false;
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNcount_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox1.Text);

                if (RBplus.Checked == true)
                {
                    c = a + b;
                    MessageBox.Show($"Součet čísel {a} a {b} se rovná {c}");
                }
                else if (RBminus.Checked == true)
                {
                    c = a - b;
                    MessageBox.Show($"Rozdíl čísel {a} a {b} se rovná {c}");
                }
                else if (RBkrat.Checked == true)
                {
                    c = a * b;
                    MessageBox.Show($"Součin čísel {a} a {b} se rovná {c}");
                }
                else if (RBdeleno.Checked == true)
                {

                    if (a > 0 && b > 0)
                    {
                        c = a / b;
                        MessageBox.Show($"Podíl čísel {a} a {b} se rovná {c}");
                    }
                    else
                    {
                        MessageBox.Show("Dělení nulou, prosím zadejte znovu!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vyberte alespoň jednu možnost výpočtu");
                }
            }
            catch (Exception)
            {
                string zprava = "Zadejte prosím všechny hodnoty";
                MessageBox.Show(zprava); 
            }
        }

    }
}
