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
    public partial class all : Form
    {
        public all()
        {
            InitializeComponent();
            even();
        }
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void even()
        {
            //s.Open();
            string surov = "SELECT * from event";
            SqlDataAdapter sd = new SqlDataAdapter(surov, s);
            SqlCommandBuilder bu = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            StDataG.DataSource = ds.Tables[0];
            s.Close();

        }
        private void StAddBtn_Click(object sender, EventArgs e)
        {
            if (StName.Text == "" || StSurname.Text == "" || StRegistr.Text == "")
            {
                MessageBox.Show("Iltimos Hamma Ma'lumotni kiriting!");
            }
            else
            {

                s.Open();
                SqlCommand c = new SqlCommand("insert into event(Name, During,Date) values (@sName,@During,@Date)", s);
                c.Parameters.AddWithValue("@sName", StName.Text);
                c.Parameters.AddWithValue("@During", StSurname.Text);


                c.Parameters.AddWithValue("@Date", StRegistr.Value.Date);
                c.ExecuteNonQuery();
                s.Close();
                even();
                load a = new load();
                a.Show();





            }
        }
        int K = 0;

        private void StDataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StName.Text = StDataG.SelectedRows[0].Cells[1].Value.ToString();
            StSurname.Text = StDataG.SelectedRows[0].Cells[2].Value.ToString();
            StRegistr.Text = StDataG.SelectedRows[0].Cells[3].Value.ToString();


            if (StName.Text == "")
            {
                K = 0;
            }
            else
            {
                K = Convert.ToInt32(StDataG.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void StDeleteBtn_Click(object sender, EventArgs e)
        {
            if (K == 0)
            {
                MessageBox.Show("Iltimos tanlang");
            }
            else
            {


                s.Open();
                SqlCommand d = new SqlCommand("delete from event where Id=@Stk", s);
                d.Parameters.AddWithValue("@Stk", K);
                d.ExecuteNonQuery();
                MessageBox.Show("Delete");
                even();
                s.Close();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton2.Text == ">")
            {
                guna2Transition1.ShowSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = "<";
            }
            else
            {
                guna2Transition2.HideSync(guna2ShadowPanel1);
                guna2CircleButton2.Text = ">";
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
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
            guna2Transition3.HideSync(se);
        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            guna2Transition3.ShowSync(se);
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
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

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            teacher a = new teacher();
            a.Show();
            this.Hide();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string surov = "SELECT Id,Name as Name,During as Surname, Date as Gender from event Where Name Like @Name+'%' ";
            SqlCommand sd = new SqlCommand(surov, s);
            sd.Parameters.AddWithValue("@Name", se.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sd;
            DataTable dt = new DataTable();
            dt.Clear();


            da.Fill(dt);
            StDataG.DataSource = dt;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap im = new Bitmap(StDataG.Width, StDataG.Height);
            StDataG.DrawToBitmap(im, new Rectangle(0, 0, StDataG.Width, StDataG.Height));
            e.Graphics.DrawImage(im, 120, 120);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            StName.Text = "";
            StSurname.Text = "";
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
