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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int Registr2;
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            formRaschetZP frm1 = this.Owner as formRaschetZP;
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Hide();
        }
    }
}

