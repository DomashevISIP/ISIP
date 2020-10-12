using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class Goroskop : Form
    {
        public Goroskop()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBxChislo_TextChanged(object sender, EventArgs e)
        {
            if (txtBxChislo.Text != "" || txtBxMonth.Text != "")
            {
                btnGoroskop.Enabled = true;
            }

        }

        private void Goroskop_Load(object sender, EventArgs e)
        {
            
        }

        private void lstBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGoroskop_Click(object sender, EventArgs e)
        {

            int chislo = Convert.ToInt32(txtBxChislo.Text);
            string Month = txtBxMonth.Text;
           
            if ( Month=="Марта" && chislo>=21&&chislo<=31 || Month=="Апреля"&& chislo >=1 && chislo <=20)
            {
                
                DataBase.ZnakZodiaka = "Овен";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Апреля" && chislo >= 21 && chislo <= 31 || Month == "Мая" && chislo >= 1 && chislo <= 21)
            {

                DataBase.ZnakZodiaka = "Телец";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Мая" && chislo >= 22 && chislo <= 31 || Month == "Июня" && chislo >= 1 && chislo <= 21)
            {

                DataBase.ZnakZodiaka = "Близнецы";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Июня" && chislo >= 22 && chislo <= 30 || Month == "Июля" && chislo >= 1 && chislo <= 22)
            {

                DataBase.ZnakZodiaka = "Рак";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Июля" && chislo >= 23 && chislo <= 31 || Month == "Августа" && chislo >= 1 && chislo <= 23)
            {

                DataBase.ZnakZodiaka = "Лев";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Августа" && chislo >= 24 && chislo <= 31 || Month == "Сентября" && chislo >= 1 && chislo <= 23)
            {

                DataBase.ZnakZodiaka = "Дева";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Сентября" && chislo >= 24 && chislo <= 30 || Month == "Октября" && chislo >= 1 && chislo <= 23)
            {

                DataBase.ZnakZodiaka = "Весы";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Октября" && chislo >= 24 && chislo <= 31 || Month == "Ноября" && chislo >= 1 && chislo <= 22)
            {

                DataBase.ZnakZodiaka = "Скорпион";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Ноября" && chislo >= 23 && chislo <= 30 || Month == "Декабря" && chislo >= 1 && chislo <= 21)
            {

                DataBase.ZnakZodiaka = "Стрелец";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Декабря" && chislo >= 22 && chislo <= 31 || Month == "Января" && chislo >= 1 && chislo <= 20)
            {

                DataBase.ZnakZodiaka = "Козерог";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();

            }
            if (Month == "Января" && chislo >= 21 && chislo <= 31 || Month == "Февраля" && chislo >= 1 && chislo <= 18)
            {

                DataBase.ZnakZodiaka = "Водолей";
                FormZnak frm = new FormZnak();
                this.Hide();
                frm.Show();
            }
            if ((chislo < 1 || chislo > 31) || (Month != "Марта" && Month != "Апреля" && Month != "Мая" && Month != "Июня"
                && Month != "Июля" && Month != "Августа" && Month != "Сентября" && Month != "Октября"
                && Month != "Ноября" && Month != "Декабря" && Month != "Февраля " && Month != "Января"))
            {
                DialogResult result = MessageBox.Show(
                   "У вас ошибка",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes) Application.Exit();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы действительно хотите выйти?",
               "?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes) Application.Exit();
        }

        private void txtBxChislo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void txtBxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBxMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtBxChislo.Text != "" || txtBxMonth.Text != "")
            {
                btnGoroskop.Enabled = true;
            }
        }

        private void lblZagolovok_Click(object sender, EventArgs e)
        {

        }
    }
}
