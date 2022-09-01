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
    public partial class Inventory : Form
    {
        InvData invdata;
        string packageSelection;
        public Inventory(string username)
        {
            InitializeComponent();
            lbl_user.Text = username;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                invdata = new InvData();
                invdata.itemName = txt_itemName.Text;
                invdata.itemNumber = int.Parse(txt_itemNumber.Text);
                invdata.regDate = Convert.ToString(dtp_dateReg.Value);
                invdata.itemPrice = double.Parse(txt_itemPrice.Text);
                invdata.count = int.Parse(txt_itemCount.Text);
                invdata.invNumber = int.Parse(txt_inventoryNumber.Text);

                string selectedItems = "";

                if (clbox_deliveryDate.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < clbox_deliveryDate.CheckedItems.Count; i++)
                    {
                        selectedItems = selectedItems + 
                            "Selected choice " + 
                            (i + 1).ToString() + " is: " +
                            clbox_deliveryDate.CheckedItems[i].ToString() + "\n";
                    }
                }

                invdata.deliveryDate = selectedItems;
                invdata.packageSelection = packageSelection;
                if (runValidation(invdata))
                {
                    invdata.Save();
                    dgv_output.DataSource = null;
                    dgv_output.DataSource = invdata.Print();
                }
                else
                {
                    MessageBox.Show("Entered data is not correct.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Record Entry Error. Please check your entry.");
            }
        }

        private bool runValidation(InvData iData)
        {
            DataValidator dvalidator = new DataValidator(iData);
            if (dvalidator.validateName())
            {
                if (dvalidator.validateNumbers())
                {
                    if (dvalidator.validateCount())
                    {
                        if (dvalidator.validatePrice())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_itemName.Text = "";
            txt_itemNumber.Text = "";
            dtp_dateReg.Value = DateTime.Now;
            txt_itemPrice.Text = "";
            txt_itemCount.Text = "";
            txt_inventoryNumber.Text = "";
            while (clbox_deliveryDate.CheckedIndices.Count > 0)
            {
                clbox_deliveryDate.SetItemChecked(clbox_deliveryDate.CheckedIndices[0], false);
            }
            cbox_checked.Checked = false;
            cbox_approved.Checked = false;
            rad_batch.Checked = false;
            rad_single.Checked = false;
            dgv_output.DataSource = null;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rad_single_CheckedChanged(object sender, EventArgs e)
        {
            packageSelection = "Single Package";
        }

        private void rad_batch_CheckedChanged(object sender, EventArgs e)
        {
            packageSelection = "Batch Package";
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            rad_batch.Checked = false;
            rad_single.Checked = false;
        }
    }
}
