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
    public partial class Detail : Form
    {
        ProductCard selectedCard;
        public Detail(List<InvData> data, ProductCard selectedCard)
        {
            InitializeComponent();
            this.selectedCard = selectedCard;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            InvData data = new InvData();
            List<InvData> list = data.Print();

            bool checkpoint = false;
            if(selectedCard != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].itemName.Equals(selectedCard.ProdTitle))
                    {
                        txt_Name.Text = list[i].itemName;
                        txt_InventoryNumber.Text = list[i].invNumber.ToString();
                        txt_EntryNumber.Text = list[i].itemNumber.ToString();
                        txt_Count.Text = list[i].count.ToString();
                        txt_Price.Text = list[i].itemPrice.ToString();
                        txt_Date.Text = list[i].regDate;
                        Show();
                        checkpoint = true;
                    }
                }
                if (!checkpoint)
                {
                    MessageBox.Show("Details not found");
                }
            }
            else
            {
                MessageBox.Show("Can not find product");
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
