using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryHandler
{
    public class DataValidator
    {
        InvData itemData;

        public DataValidator(InvData iData)
        {
            itemData = iData;
        }

        public bool validateName()
        {
            Regex nameRegex = new Regex("^[A-Za-z\\s]{5,100}$");
            if (nameRegex.IsMatch(itemData.itemName))
            {
                return true;
            }
            return false;
        }
        public bool validateNumbers()
        {
            Regex NumRegex = new Regex("^[0-9]{1,6}$");
            if (NumRegex.IsMatch(itemData.itemNumber.ToString()))
            {
                return true;
            }
            return false;
        }
        public bool validateCount()
        {
            Regex CountRegex = new Regex("^[1-9]{1,5}$");
            if (CountRegex.IsMatch(itemData.count.ToString()))
            {
                return true;
            }
            return false;
        }
        public bool validatePrice()
        {
            Regex PriceRegex = new Regex("^[0-9]{1,6}[.]{0,1}[0-9]{1,2}$");
            if (PriceRegex.IsMatch(itemData.itemPrice.ToString()))
            {
                return true;
            }
            return false;
        }
    }
}
