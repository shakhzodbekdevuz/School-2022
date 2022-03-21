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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void st()
        {
            s.Open();
            //string surov = "SELECT count(*) from Tolov ",s;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Count(*) from Student ", s);
            DataTable ss = new DataTable();
            sd.Fill(ss);
            guna2HtmlLabel1.Text = ss.Rows[0][0].ToString();
            s.Close();
        }
        private void st1()
        {
            s.Open();
            //string surov = "SELECT count(*) from Tolov ",s;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Count(*) from Teacher ", s);
            DataTable ss = new DataTable();
            sd.Fill(ss);
            tl.Text = ss.Rows[0][0].ToString();
            s.Close();
        }
        private void st2()
        {
            s.Open();
            //string surov = "SELECT count(*) from Tolov ",s;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Count(*) from Tolov ", s);
            DataTable ss = new DataTable();
            sd.Fill(ss);
            l.Text = ss.Rows[0][0].ToString();
            s.Close();
        }
        private void st4()
        {
            s.Open();
            //string surov = "SELECT count(*) from Tolov ",s;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Count(*) from event ", s);
            DataTable ss = new DataTable();
            sd.Fill(ss);
            el.Text = ss.Rows[0][0].ToString();
            s.Close();
        }

        private void st3()
        {
            s.Open();
            //string surov = "SELECT count(*) from Tolov ",s;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Sum(Tsumma) from Tolov ", s);
            DataTable ss = new DataTable();
            sd.Fill(ss);
            pay.Text = ss.Rows[0][0].ToString();
            s.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            st();
            st1();
            st2();
            st3();
            st4();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            if (guna2CircleButton2.Text == ">")
            {
                guna2Transition3.ShowSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = "<";
            }
            else
            {
                guna2Transition4.HideSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = ">";
            }
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            teacher a = new teacher();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
            all a = new all();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            st a = new st();
            a.Show();
            this.Hide();
        }
    }
}
