using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAddProduct : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=clothesstoredb;User ID=root;Password=valsoreda;";

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            string description = textBoxDescription.Text;
            decimal price = numericUpDownPrice.Value;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO products (product_name, description, price) VALUES (@name, @description, @price)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", productName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@price", price);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product added successfully!");
                    this.Close(); // Close after successful insert
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product: " + ex.Message);
                }
            }
        }
    }
}