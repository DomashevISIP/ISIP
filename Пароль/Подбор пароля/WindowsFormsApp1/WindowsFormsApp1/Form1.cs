using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string text = txtB1.Text;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "password.txt";
                saveFileDialog1.Filter = "txt files (.txt)|.txt|All files (.)|.";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    File.WriteAllText(filename, text);
                    MessageBox.Show("Файл сохранен");
                }
            }
        }

        private void btnProverka_Click(object sender, EventArgs e)
        {
            password = Convert.ToString("I$2020");
            try
            {
                
            }
            
            finally
            {
                btnSave.Enabled = true;
                if (txtB1.Text == password)
                { MessageBox.Show("Пароль верный"); }
            
            
                else
                {
                    btnSave.Enabled = false;
                    MessageBox.Show("Пароль не верный"); 
                }
        }
    }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
