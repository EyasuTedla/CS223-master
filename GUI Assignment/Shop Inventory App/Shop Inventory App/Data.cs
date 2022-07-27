using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyShop
{
    internal class Data
    {
        public string name { get; set; }
        public string number { get; set; }
        public string invNumber { get; set; }
        public string date { get; set; }
        public string count { get; set; }
        public string price { get; set; }


        public void Save()
        {
            System.Windows.Forms.MessageBox.Show(
                "Item Saved as " + 
                " \n Name [ " + name + " ] " +
                " \n Number [ " + number + " ] " +
                " \n Inventory number [ " + invNumber + " ] " +
                " \n Date [ " + date + " ] " +
                " \n Count [ " + count + " ] " +
                " \n Price [ " + price + " ] ");
        }
    }
}
