using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGroup
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void formMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (tbSurname.Text != "" && tbName.Text != "" && tbPatronymic.Text != "" && tbAddress.Text != "" && tbNumber.Text != "")
            {
                gridMain.Rows.Add(tbSurname.Text, tbName.Text, tbPatronymic.Text, tbAddress.Text, tbNumber.Text);
            }
            else
            {
               MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                gridMain.Rows.RemoveAt(gridMain.SelectedCells[0].RowIndex);
            }
            catch
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            gridMain.ReadOnly = false;
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPatronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
