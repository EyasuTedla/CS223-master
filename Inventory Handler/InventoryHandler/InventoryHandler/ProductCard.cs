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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        private string _title;

        public string ProdTitle
        {
            get { return _title; }
            set { _title = value; lbl_productName.Text = value; }
        }

        private int _invNumber;

        public int InventoryNumber
        {
            get { return _invNumber; }
            set { _invNumber = value; lbl_invNumber.Text = value.ToString(); }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value.ToString(); }
        }


    }
}
