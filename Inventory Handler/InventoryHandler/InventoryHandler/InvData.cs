using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryHandler
{
    public class InvData
    {
        public int itemNumber { get; set; }
        public string regDate { get; set; }
        public int invNumber { get; set; }
        public string itemName { get; set; }
        public int count { get; set; }
        public double itemPrice { get; set; }
        public string packageSelection { get; set; }
        public string deliveryDate { get; set; }

        public static List<InvData> itemList = new List<InvData>();

        public void Save()
        {
            itemList.Add(this);
        }

        public List<InvData> Print()
        {
            return itemList;
        }

        public static InvData searchForProduct(string name)
        {
            return itemList.Find(prod => prod.itemName == name);
        }
    }
}
