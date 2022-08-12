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
    public partial class Login : Form
    {
        Form MainForm;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin")
            {
                if(txt_password.Text == "admin")
                {
                    MainForm = new Inventory(txt_username.Text);
                    MainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
