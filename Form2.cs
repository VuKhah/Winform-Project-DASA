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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_price_Click(object sender, EventArgs e)
        {

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            int d_nsx = txb_time_NSX.Value.Date.Day;
            int m_nsx = txb_time_NSX.Value.Date.Month;
            int y_nsx = txb_time_NSX.Value.Date.Year;

            int d_hsd = txb_time_HSD.Value.Date.Day;
            int m_hsd = txb_time_HSD.Value.Date.Month;
            int y_hsd = txb_time_HSD.Value.Date.Year;

            int d_nnk = txb_time_NNK.Value.Date.Day;
            int m_nnk = txb_time_NNK.Value.Date.Month;
            int y_nnk = txb_time_NNK.Value.Date.Year;

            DateTime nsx_Date = new DateTime(y_nsx, m_nsx, d_nsx);
            DateTime hsd_Date = new DateTime(y_hsd, m_hsd, d_hsd);
            DateTime nnk_Date = new DateTime(y_nnk, m_nnk, d_nnk);

            int quantity;
            if (int.TryParse(txb_quantity.Text, out quantity)){}
            else  quantity = 0;

            decimal price;
            if (decimal.TryParse(txb_price.Text, out price)) { }
            else price = 0;


            Item ADD = new Item(txb_name.Text, setImage(), nsx_Date, hsd_Date, nnk_Date, quantity, price, txb_info.Text);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Image setImage()
        {
            return panel_image.BackgroundImage;
        }
        
    }
}
