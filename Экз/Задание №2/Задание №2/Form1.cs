using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            int price = 6;
            int time = Convert.ToInt32(txtTime.Text);
            int day = Convert.ToInt32(txtDay.Text);

            if (day <= 0 || day >= 8)
            {
                MessageBox.Show("Ошибка", "Сообщение");
            }
            if (day == 6 || day == 7)
            {
                double total = (time * price) - (time * price * 0.2);
                MessageBox.Show("Длительность разговора " + time + " мин. Он произошёл в " + day + "-й день недели. Его стоимость составила " + total + " руб.", "Сообщение");
            }
            if (day >= 1 && day <= 5)
            {
                int total = time * price;
                MessageBox.Show("Длительность разговора " + time + " мин. Он произошёл в " + day + "-й день недели. Его стоимость составила " + total + " руб.", "Сообщение");
            }
            txtDay.Clear();
            txtTime.Clear();
            btnPrice.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Clear();
            txtTime.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (txtTime.Text.Length > 0 && txtDay.Text.Length > 0)
            {
                btnPrice.Enabled = true;
            }
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (txtDay.Text.Length > 0 && txtTime.Text.Length > 0)
            {
                btnPrice.Enabled = true;
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }
    }
}
