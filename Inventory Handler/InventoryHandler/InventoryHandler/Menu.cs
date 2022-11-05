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
    public partial class Menu : Form
    {
        string username;

        public Menu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var InvForm = new Inventory(username);
            InvForm.MdiParent = this;
            InvForm.Show();

        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var searchForm = new Search();
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void displayProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var DisForm = new FlowLayoutDisplay();
            DisForm.MdiParent = this;
            DisForm.Show();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
