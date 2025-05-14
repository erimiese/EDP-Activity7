using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ForgotPass : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=clothesstoredb;User ID=root;Password=valsoreda;";

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = same_email.Text.Trim();
            string newPassword = new_pass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill out both Email and Password fields.");
                return;
            }

            string hashedPassword = HashPassword(newPassword);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE users SET password = @password WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password successfully updated.");
                            this.Hide(); // or this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No user found with that email.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Simple SHA256 hash function
        private string HashPassword(string password)
{
    using (SHA256 sha = SHA256.Create())
    {
        byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        StringBuilder builder = new StringBuilder();
        foreach (byte b in bytes)
            builder.Append(b.ToString("x2"));
        return builder.ToString();
    }
}

        private void done_btn_Click(object sender, EventArgs e)
        {
            string email = same_email.Text.Trim();
            string newPassword = new_pass.Text.Trim();

            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void show_Newpass_CheckedChanged(object sender, EventArgs e)
        {
            new_pass.PasswordChar = show_Newpass.Checked ? '\0' : '*';
        }
    }
}
