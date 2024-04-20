using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Reflection.Metadata.BlobBuilder;


namespace GiftShopManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        sqlconnection co = new sqlconnection("YourConnectionStringHere");
        public static string User = " ";

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == "admin" || passwordbox.Text == "admin123")
            {
                Products obj = new Products();
                obj.Show();
                this.Hide();
            }


            else if (usernamebox.Text == " " || passwordbox.Text == " ")
            {
                MessageBox.Show("Invalid User or Password !");
            }
            else
            {

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable("select count(*) From UserNamebox where UName='" + usernamebox.Text + "' and UPass='" + passwordbox.Text + "'");
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = usernamebox.Text;
                    Sell obj = new Sell();
                    obj.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid User or Password !");
                }
            }

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
