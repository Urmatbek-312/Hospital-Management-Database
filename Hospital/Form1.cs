using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String pass = txtPassword.Text;

            if(username == "urmat" && pass == "1234")
            {
               // MessageBox.Show("You have to entered right username or password");


               this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show(); 
            }
            else
            {
                MessageBox.Show("wrong user id or password"); 
            }




        }
    }
}
