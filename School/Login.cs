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
using System.Configuration;

namespace School
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pa.Text == "" && us.Text == "")
            {
                MessageBox.Show("Iltimos ma'lumotlarni kiriting");
            }
            else
            {
                if (pa.Text == "123" && us.Text == "admin")
                {
                     FirstPage a = new FirstPage();
                        a.Show();
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("Login yoki Parol notog'ri");
                }
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
