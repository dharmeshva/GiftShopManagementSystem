using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GiftShopManagementSystem
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            DataAccess da = new DataAccess();
            string query = "select * from BookTbl";
            DataSet ds = da.ExecuteQuery(query);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string error = "";
            int i = 0;

            if (usernamebox.Text == "")
            {
                error += "Username is required.\n";
                i++;
            }

            if (Phone.Text == "")
            {
                error += "Phone is required.\n";
                i++;
            }

            if (Address.Text == "")
            {
                error += "Address is required.\n";
                i++;
            }
            

            if (Productname.Text == "")
            {
                error += "Productname is required.\n";
                i++;
            }
            if (Quantity.Text == "")
            {
                error += "Quantity is required.\n";
                i++;
            }

            if (i > 0)
            {
                MessageBox.Show($"Missing Information ! \n {error}");
            }


            else
            {

                try
                {
                    DataAccess dataAccess = new DataAccess();
                    string query = "insert into UserTbl values('" + usernamebox.Text + "','" + Phone.Text + "','" + Address.Text + "','" + Productname.Text + "','" + Quantity.Text + "')";
                    int rowsAffected = dataAccess.ExecuteDMLQuery(query);
                    MessageBox.Show("Data Inserted !");
                    populate();
                    Reset();

                }

                catch (Exception Ex)
                {

                    MessageBox.Show("Ex.message");
                }

            }
        }

        public void Reset()
        {

            usernamebox.Text = "";
            Phone.Text = "";
            Address.Text = "";
            Productname.Text = "";
            Quantity.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
