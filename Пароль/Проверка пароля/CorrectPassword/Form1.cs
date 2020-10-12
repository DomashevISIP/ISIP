using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectPassword
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(String message) : base(message)
        { }

        public WrongPasswordException(String message, Exception inner) : base(message, inner) { }
    }

    public partial class EnterPass : Form
    {
        public EnterPass()
        {
            InitializeComponent();
        }

        private void ProcessString(string password)
        {
            bool isUpper = false;
            
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == password.ToUpper()[i])
                {
                    isUpper = true;
                }
            }

            bool isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    isNumber = true;
                }
            }
          
            if 
            (
           !(password.Contains("!")||
            password.Contains("@")||
            password.Contains("#")||
            password.Contains("$")||
            password.Contains("%")||
            password.Contains("^")))
            {
                throw new WrongPasswordException("WrongPassword");
            }
            if (isUpper == false)
            {
                throw new WrongPasswordException("WrongPassword");
            }
            else if (isNumber == false)
            {
                throw new WrongPasswordException("WrongPassword");
            }
            else if (password.Length < 6)
            {
                throw new WrongPasswordException("WrongPassword");
            }
        }

        private void TryCatch()
        {
            string password = tbPassword.Text;
            try
            {
                ProcessString(password);
                File.WriteAllText("password.txt", password);
                MessageBox.Show("Пароль записан.", "", MessageBoxButtons.OK);
            }
            catch (WrongPasswordException)
            {
                MessageBox.Show("ПАРОЛЬ ВВЕДЁН НЕКОРРЕКТНО\nМинимум один из данных символов: !, @, #, $, %, ^\nМинимум 6 символов\nМинимум 1 прописная буква\nМинимум 1 цифра","НЕКОРРЕКТНЫЙ ВВОД",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error); ;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TryCatch();
        }
    }
}
