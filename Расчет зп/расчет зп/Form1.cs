using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace расчет_зп
{
    public partial class formRaschetZP : Form
    {
        public formRaschetZP()
        {
            InitializeComponent();
        }

        int staj, categ, oplata, days, hours;
        double tax, itg, uderj, vidano;

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tBox1.Text = "";
            tBox2.Text = "";
            cBox1.Text = "";
        }

        private void formRaschetZP_Load(object sender, EventArgs e)
        {

        }

        private void tBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

        }

        private void tBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void cBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
            
                if (rBtn1.Checked == true)
                {
                    staj = 0;
                }
                else if (rBtn2.Checked == true)
                {
                    staj = 2000;
                }
                else if (rBtn3.Checked == true)
                {
                    staj = 4000;
                }


                if (rbFirst.Checked == true)
                {
                    categ = 0;
                }
                else if (rbSecond.Checked == true)
                {
                    categ = 1000;
                }
                else if (rbThird.Checked == true)
                {
                    categ = 2000;
                }

                oplata = int.Parse(tBox1.Text);
                tax = int.Parse(tBox2.Text);
                days = int.Parse(cBox1.Text);
                if (lbHours.SelectedIndex == 0)
                {
                    hours = 8;
                }
                else if (lbHours.SelectedIndex == 1)
                {
                    hours = 6;
                }
                formRaschetZP frm1 = this.Owner as formRaschetZP;
                itg = (staj + categ) + (oplata * hours * days);
                uderj = ((tax / 100) * itg);
                vidano = (itg - uderj);
                frm2.label4.Text = itg.ToString();
                frm2.label5.Text = uderj.ToString();
                frm2.label6.Text = vidano.ToString();
            
            Raschet.Enabled = false;

        }

        private void tBox1_TextChanged(object sender, EventArgs e)
        {
            if (tBox1.Text != "" && tBox2.Text != "" && cBox1.Text != "")
            {
                Raschet.Enabled = true;
            }
        }
        private void tBox2_TextChanged(object sender, EventArgs e)
        {
            if (tBox1.Text != "" && tBox2.Text != "" && cBox1.Text != "")
            {
                Raschet.Enabled = true;
            }
        }

        private void сBox1_TextChanged(object sender, EventArgs e)
        {
            if (tBox1.Text != "" && tBox2.Text != "" && cBox1.Text != "")
            {
                Raschet.Enabled = true;
            }
        }

    }
}
