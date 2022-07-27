using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EazyShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            Data myData = new Data();
            myData.name = txt_objectName.Text;
            myData.number = txt_number.Text;
            myData.date = Convert.ToString(date_dateReg.Value);
            myData.price = txt_price.Text;
            myData.count = txt_count.Text;
            myData.invNumber = txt_inventoryNumber.Text;
            myData.Save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_number.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            txt_inventoryNumber.Text = "";
            txt_count.Text = "";
            date_dateReg.Value = DateTime.Now;
        }
    }
}
