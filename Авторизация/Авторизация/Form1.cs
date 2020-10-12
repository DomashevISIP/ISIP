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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnVxod_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line = sr.ReadToEnd();
                    string[] array = line.Split("\r\n;".ToCharArray());
                    if ((tbxLogin.Text == array[0] && tbxPassword.Text == array[1]) || (tbxLogin.Text == array[3] && tbxPassword.Text == array[4]) ||
                    (tbxLogin.Text == array[6] && tbxPassword.Text == array[7]))
                    {
                        MessageBox.Show("Вход выполнен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все условия выполнены", "Information");
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
           
                Form2 frm2 = new Form2();
            frm2.Show(this);
        }

        private void tbxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}


    

