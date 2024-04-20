using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Intrinsics.X86;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace GiftShopManagementSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            populate();
        }

        public void populate()
        {
            DataAccess da = new DataAccess();
            string query = "select * from UserTbl";
            DataSet ds = da.ExecuteQuery(query);
            usernamebox.DataSource = ds.Tables[0];

        }
        public void Reset()
        {
            usernamebox.Text = "";
            phone.Text = "";

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string error = "";
            int i = 0;

            if (usernamebox.Text == "")
            {
                error += "Username is required.\n";
                i++;
            }

            if (phone.Text == "")
            {
                error += "Phone is required.\n";
                i++;
            }


            else
            {

                try
                {
                    DataAccess dataAccess = new DataAccess();
                    string query = "insert into UserTbl values('" + usernamebox.Text + "','" + phone.Text + "')";
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

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (key == 0 || string.IsNullOrEmpty(usernamebox.Text) || string.IsNullOrEmpty(phone.Text))
            {
                MessageBox.Show("Missing Information or Invalid Key!");
                return;
            }

            try
            {

                DataAccess da = new DataAccess();

                string query = "update UserTbl set UName='" + usernamebox.Text + "',UPhone='" + phone.Text + "';";

                da.ExecuteDMLQuery(query);


                MessageBox.Show("Data Updated!");
                populate();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }



        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }
            DataAccess da = new DataAccess();
            try
            {

                string query = "delete from UserTbl where UId=" + key + ";";
                int rowsAffected = da.ExecuteDMLQuery(query);
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Data Deleted!");
                    populate();
                    Reset();
                }

                else
                {
                    MessageBox.Show("No data deleted. User not found.");
                }
            }

            catch (Exception Ex)
            {

                MessageBox.Show($"Error: {Ex.Message}");
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                usernamebox.Text = row.Cells["UName"].Value.ToString();
                phone.Text = row.Cells["UPhone"].Value.ToString();



                if (string.IsNullOrEmpty(usernamebox.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells["UId"].Value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Sell obj = new Sell();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }
    }
}
