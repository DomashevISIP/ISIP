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

namespace Авторизация
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string password = tbxPassword.Text;
                if (password.Length >= 6 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) >= 0)
                {
                    DialogResult save = MessageBox.Show("Мы сохраним ваш пароль ", "Предупреждение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                    string Dano = tbxLogin.Text +';'+ tbxPassword.Text;
                    StreamWriter SW = new StreamWriter("user.txt", true);
                    SW.Write("\r\n"+Dano);
                    SW.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все условия выполнены", "Information");
            }
        }
    }
}
