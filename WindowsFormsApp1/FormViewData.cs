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
    public partial class FormViewData : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=clothesstoredb;User ID=root;Password=valsoreda;";

        public FormViewData()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormViewData_Load);
        }

        private void FormViewData_Load(object sender, EventArgs e)
        {
            LoadTableNames();
        }

        private void LoadTableNames()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    DataTable dt = conn.GetSchema("Tables");
                    comboTables.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string tableName = row[2].ToString();
                        comboTables.Items.Add(tableName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tables: " + ex.Message);
                }
            }
        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                string selectedTable = comboTables.SelectedItem.ToString();
                string query = $"SELECT * FROM {selectedTable}";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading table data: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                string selectedTable = comboTables.SelectedItem.ToString();
                string query = $"SELECT * FROM {selectedTable}";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading table data: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
