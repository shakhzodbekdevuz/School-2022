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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
            Teacher();
        }

        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Teacher()
        {
            
            string surov = "SELECT * from Teacher";
            SqlDataAdapter sd = new SqlDataAdapter(surov,s);
            SqlCommandBuilder bu = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            GnDVW.DataSource=ds.Tables[0];
            s.Close();
        }
        private void guna2ProgressIndicator1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            load a = new load();
            a.Show();
            if (name.Text == "" || familiya.Text == "" || gender.SelectedIndex == -1 || dob.Text == "" || tel.Text == "" || adress.Text == "" || sub.SelectedIndex == -1 || add.Text == "")
            {
                MessageBox.Show("Iltimos Hamma Ma'lumotni kiriting!");
            }
            else
            {

                s.Open();
                SqlCommand c = new SqlCommand("insert into Teacher(Tname,Tsurname,Tgender,Tdata,Tadress,Tphone,Tsub,Tqu) values (@tName,@tSurname,@tGender,@tDay,@tAdress,@tPhone,@tSubject,@tQush)", s);
                c.Parameters.AddWithValue("@tName", name.Text);
                c.Parameters.AddWithValue("@tSurname", familiya.Text);
                c.Parameters.AddWithValue("@tGender", gender.Text);
                c.Parameters.AddWithValue("@tDay", dob.Value.Date);
                c.Parameters.AddWithValue("@tAdress", adress.Text);
                c.Parameters.AddWithValue("@tPhone", tel.Text);
                c.Parameters.AddWithValue("@tSubject", sub.Text);
                c.Parameters.AddWithValue("@tQush", add.Text);
                c.ExecuteNonQuery();
                s.Close();


                //load a = new load();
                //a.Show();

            }
        }
        private void teacher_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(guna2ShadowPanel1);
        }

        private void leButton1_Click(object sender, EventArgs e)
        {
            guna2Transition3.HideSync(guna2ShadowPanel1);
        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton2.Text == ">")
            {
                guna2Transition4.ShowSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = "<";
            }
            else
            {
                guna2Transition5.HideSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = ">";
            }
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            if (guna2CircleButton1.Text == "+")
            {
                guna2Transition1.ShowSync(guna2ShadowPanel2);
                guna2CircleButton1.Text = "-";
            }
            else
            {
                guna2Transition2.HideSync(guna2ShadowPanel2);
                guna2CircleButton1.Text = "+";
            }
            guna2Transition6.HideSync(se);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Teacher();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            familiya.Text = "";
            gender.SelectedIndex = -1;
            adress.Text = "";
            tel.Text = "";
            sub.SelectedIndex = -1;
            add.Text = "";
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            guna2Transition6.ShowSync(se);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            st a = new st();
            a.Show();
            this.Hide();
        }
        int K = 0;
        private void GnDVW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = GnDVW.SelectedRows[0].Cells[1].Value.ToString();
            familiya.Text = GnDVW.SelectedRows[0].Cells[2].Value.ToString();
            gender.Text = GnDVW.SelectedRows[0].Cells[3].Value.ToString();
            dob.Text = GnDVW.SelectedRows[0].Cells[4].Value.ToString();
            adress.Text = GnDVW.SelectedRows[0].Cells[6].Value.ToString();
            tel.Text = GnDVW.SelectedRows[0].Cells[5].Value.ToString();
            sub.Text = GnDVW.SelectedRows[0].Cells[7].Value.ToString();

            add.Text = GnDVW.SelectedRows[0].Cells[8].Value.ToString();
           

            if (name.Text == "")
            {
                K = 0;
            }
            else
            {
                K = Convert.ToInt32(GnDVW.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void dton1_Click(object sender, EventArgs e)
        {
            if (K == 0)
            {
                MessageBox.Show("Iltimos tanlang");
            }
            else
            {


                s.Open();
                SqlCommand d = new SqlCommand("delete from Teacher where Id=@Stk", s);
                d.Parameters.AddWithValue("@Stk", K);
                d.ExecuteNonQuery();
                MessageBox.Show("Delete");
                Teacher();
                s.Close();
            }
    }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            all a = new all();
            a.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap im = new Bitmap( GnDVW.Width,GnDVW.Height);
            GnDVW.DrawToBitmap(im, new Rectangle(0, 0, GnDVW.Width, GnDVW.Height));
            e.Graphics.DrawImage(im, 5, 10);
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string surov = "SELECT Id,Tname as Name,Tsurname as Surname, Tgender as Gender,Tdata as Day,Tadress as adress, Tphone as Phone,Tsub as Subject, Tqu as qu from Teacher Where Tname Like @Name+'%' ";
            SqlCommand sd = new SqlCommand(surov, s);
            sd.Parameters.AddWithValue("@Name", se.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sd;
            DataTable dt = new DataTable();
            dt.Clear();


            da.Fill(dt);
            GnDVW.DataSource = dt;
        }
    }
}
