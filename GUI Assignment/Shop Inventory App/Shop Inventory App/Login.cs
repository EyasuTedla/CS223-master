using EazyShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Inventory_App
{
    public partial class Login : Form
    {
        Form newForm;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == "admin" || txt_user.Text == "admin22")
            {
                if(txt_pass.Text == "admin")
                {
                    string name = txt_user.Text;
                    newForm = new Form1(name);
                    newForm.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txt_pass.Text = "";
                txt_user.Text = "";
            }
        }
    }
}
