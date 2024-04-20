using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftShopManagementSystem
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            DataAccess da = new DataAccess();
            string query = "select * from ProductTbl";
            DataSet ds = da.ExecuteQuery(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void filter()
        {

            DataAccess dataAccess = new DataAccess();

            string query = $"select * from ProductTbl where PCat='{PCatCbSearch.SelectedItem}'";
            DataSet ds = dataAccess.ExecuteQuery(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void Reset()
        {

            Productname.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            BCatCb.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            populate();
            PCatCbSearch.SelectedItem = -1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            string error = "";
            int i = 0;

            if (Productname.Text == "")
            {
                error += "Product name is required.\n";
                i++;
            }

            if (Quantity.Text == "")
            {
                error += "Quantity is required.\n";
                i++;
            }

            if (Price.Text == "")
            {
                error += "Product Price is required.\n";
                i++;
            }


            if (BCatCb.Text == "")
            {
                error += "Procut category is required.\n";
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
                    string query = $"insert into  ProductsTbl values('{Productname.Text}','{Quantity.Text}','{BCatCb.SelectedItem}','{Price.Text}')";
                    int result = dataAccess.ExecuteDMLQuery(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Inserted !");
                        populate();
                        Reset();
                    }
                    dataAccess.Sqlcon.Close();

                    populate();
                    Reset();

                }

                catch (Exception Ex)
                {

                    MessageBox.Show("Ex.message");
                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string error = "";
            int i = 0;

            if (Productname.Text == "")
            {
                error += "Product name is required.\n";
                i++;
            }

            if (Quantity.Text == "")
            {
                error += "Quantity is required.\n";
                i++;
            }

            if (Price.Text == "")
            {
                error += "Product Price is required.\n";
                i++;
            }


            if (BCatCb.Text == "")
            {
                error += "Procut category is required.\n";
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
                    string query = $"insert into  ProductsTbl values('{Productname.Text}','{Quantity.Text}','{BCatCb.SelectedItem}','{Price.Text}')";
                    int result = dataAccess.ExecuteDMLQuery(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Inserted !");
                        populate();
                        Reset();
                    }
                    dataAccess.Sqlcon.Close();

                    populate();
                    Reset();

                }

                catch (Exception Ex)
                {
                    string a = "";
                    int j = 0;

                    if (Productname.Text == "")
                    {
                        a += "Please enter apropriate .\n";
                        j++;
                    }

                    if (Quantity.Text == "")
                    {
                        a += "Please enter apropriate  Products quantity.\n";
                        j++;
                    }

                    
                    if (Price.Text == "")

                    {
                        a += "Please enter apropriate  Products price.\n";
                        j++;
                    }
                    if (PCatCbSearch.SelectedText == "")
                    // if (BCatCb.Text == "")
                    {
                        a += "Please select apropriate Products category.\n";
                        j++;
                    }
                    if (i > 0)
                    {
                        MessageBox.Show($"Ex.message \n Missing Information ! \n {a}");
                    }
                    MessageBox.Show($"Please enter apropriate values.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Productname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Quantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            BCatCb.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Price.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


            if (Productname.Text == "")
            {
                key = 0;

            }

            else
            {

                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
    }
}
