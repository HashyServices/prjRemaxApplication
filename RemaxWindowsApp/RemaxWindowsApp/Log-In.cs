using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemaxWindowsApp
{
    public partial class Form1 : Form
    {
        private object txt_username;
        private object txt_password;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (txt_username.txt == "stock" && txt_password.Txt == "stock")
            {
                this.Hide();
                Views.RemaxWindowsAppView stock = new Views.RemaxWindowsView();
                stock.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check USERNAME & PASSWORD!!", "Login Unsuccessful");
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginView_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            sasdsd
        }
    }
}



