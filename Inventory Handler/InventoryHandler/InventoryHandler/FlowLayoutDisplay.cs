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
    public partial class FlowLayoutDisplay : Form
    {

        InvData data = new InvData();
        List<InvData> list;
        List<ProductCard> cardCollection = new List<ProductCard>();

        public FlowLayoutDisplay()
        {
            InitializeComponent();
        }

        private void FlowLayoutDisplay_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            list = data.Print();

            foreach (InvData item in list)
            {
                ProductCard card = new ProductCard();
                card.ProdTitle = item.itemName;
                card.InventoryNumber = item.invNumber;
                card.Price = item.itemPrice;
                cardCollection.Add(card);

                card.Click += ProductCard_Click;

                flowLayoutPanel1.Controls.Add(card);

            }

        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            ProductCard selctedCard = null;
            for (int i = 0; i < cardCollection.Count; i++)
            {
                if (sender.Equals(cardCollection[i]))
                {
                    selctedCard = cardCollection[i];
                }
            }
            var display = new Detail(list, selctedCard);
            display.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
