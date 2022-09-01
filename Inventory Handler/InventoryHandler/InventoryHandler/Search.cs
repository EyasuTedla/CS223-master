using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryHandler
{
    public partial class Search : Form
    {
        InvData data;

        public Search()
        {
            InitializeComponent();
        }


        private void searchItem(string name)
        {
            data = InvData.searchForProduct(name);

            if (data != null)
            {
                txt_ItemName.Text = data.itemName;
                txt_InvNumber.Text = data.invNumber.ToString();
                txt_ItemNumber.Text = data.itemNumber.ToString();
                txt_Count.Text = data.count.ToString();
                txt_Price.Text = data.itemPrice.ToString();
                txt_Date.Text = data.regDate.ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchItem(txt_SearchQuery.Text);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
