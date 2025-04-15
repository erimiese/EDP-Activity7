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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewData viewForm = new FormViewData();
            viewForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddProduct addProductForm = new FormAddProduct();
            addProductForm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
