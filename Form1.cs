using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Project_DASA
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void view_Table_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Form2 Add_form = new Form2();
            Add_form.ShowDialog();

            view_Table_Data.DataSource = ListItems.Shop.List_Item;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
