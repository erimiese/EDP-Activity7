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
    public partial class Login : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=clothesstoredb;User ID=root;Password=valsoreda;";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn1_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = login_username.Text.Trim(); // Use a TextBox for either username or email
            string password = login_password.Text.Trim();

            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username/email and password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Updated query to check both username and email
                    string query = "SELECT * FROM users WHERE (email = @usernameOrEmail OR username = @usernameOrEmail) AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@password", password); // ⚠️ should be hashed in real apps

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username/email or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            ForgotPass forgotPassForm = new ForgotPass();
            forgotPassForm.Show();
            this.Hide();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}