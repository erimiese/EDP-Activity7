using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=clothesstoredb;User ID=root;Password=valsoreda;";

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                user_list.DataSource = dt;
            }
        }

        private void search_un_Click(object sender, EventArgs e)
        {
            string username = searchBox.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username LIKE @username";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@username", "%" + username + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                user_list.DataSource = dt;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            string newEmail = upd_email.Text.Trim();
            string newPassword = upd_pass.Text.Trim();

            if (user_list.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(user_list.SelectedRows[0].Cells["id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET Email = @Email, Password = @Password WHERE id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Rebind data and refresh the DataGridView
                BindData();
                user_list.Refresh(); // Refresh the DataGridView to ensure it shows updated data
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_list_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void searchBox_TextChanged(object sender, EventArgs e) { }
        private void upd_email_TextChanged(object sender, EventArgs e) { }
        private void upd_pass_TextChanged(object sender, EventArgs e) { }
    }
}
