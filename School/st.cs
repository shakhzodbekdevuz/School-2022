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
    public partial class st : Form
    {

        public st()
        {
            InitializeComponent();
            Student();
        }
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        { 

        }
        private void Student()
        {
            //s.Open();
            string surov = "SELECT * from Student";
            SqlDataAdapter sd = new SqlDataAdapter(surov, s);
            SqlCommandBuilder bu = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            StDataG.DataSource = ds.Tables[0];
            s.Close();
            
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void st_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            if(StName.Text=="" || StSurname.Text=="" || StGender.SelectedIndex==-1 || StDay.SelectedIndex==-1 || StPhone.Text=="" || StTime.Text=="" || StSubject.SelectedIndex==-1 || StRegistr.Text == "")
            {
                MessageBox.Show("Iltimos Hamma Ma'lumotni kiriting!");
            }
            else
            {
                
                    s.Open();
                    SqlCommand c = new SqlCommand("insert into Student(stName,stSurname,stGender,stDay,stPhone,stVaqti,stSubject,stregistr) values (@sName,@sSurname,@sGender,@sDay,@sPhone,@sVaqti,@sSubject,@sregistr)", s);
                    c.Parameters.AddWithValue("@sName", StName.Text);
                    c.Parameters.AddWithValue("@sSurname", StSurname.Text);
                    c.Parameters.AddWithValue("@sGender", StGender.Text);
                    c.Parameters.AddWithValue("@sDay", StDay.Text);
                    c.Parameters.AddWithValue("@sPhone", StPhone.Text);
                    c.Parameters.AddWithValue("@sVaqti", StTime.Text);
                    c.Parameters.AddWithValue("@sSubject", StSubject.Text);
                    c.Parameters.AddWithValue("@sregistr", StRegistr.Value.Date);
                    c.ExecuteNonQuery();
                    s.Close();
                load a = new load();
                a.Show();





            }
            //load a = new load();
            //a.Show();
        }
        int K = 0;
        private void StDataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StName.Text = StDataG.SelectedRows[0].Cells[1].Value.ToString();
            StSurname.Text = StDataG.SelectedRows[0].Cells[2].Value.ToString();
            StGender.Text = StDataG.SelectedRows[0].Cells[3].Value.ToString();
            StDay.Text = StDataG.SelectedRows[0].Cells[4].Value.ToString();
            StPhone.Text = StDataG.SelectedRows[0].Cells[5].Value.ToString();
            StTime.Text = StDataG.SelectedRows[0].Cells[6].Value.ToString();
            StSubject.Text = StDataG.SelectedRows[0].Cells[7].Value.ToString();
            StRegistr.Text = StDataG.SelectedRows[0].Cells[8].Value.ToString();

            if (StName.Text=="")
            {
                K = 0;
            }
            else
            {
                K = Convert.ToInt32(StDataG.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void deletebtn(object sender, EventArgs e)
        {
            if (K == 0)
            {
                MessageBox.Show("Iltimos tanlang");
            }
            else
            {
                
                
                    s.Open();
                    SqlCommand d = new SqlCommand("delete from Student where stId=@Stk",s);
                    d.Parameters.AddWithValue("@Stk", K);
                    d.ExecuteNonQuery();
                    MessageBox.Show("Delete");
                    Student();
                    s.Close();
                
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void a(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Student();
        }

        private void b(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }

        private void ictureBox9_Click(object sender, EventArgs e)
        {
            StName.Text="";
            StSurname.Text="";
            StGender.SelectedIndex=-1;
            StDay.SelectedIndex = -1;
            StPhone.Text = "";
            StTime.SelectedIndex = -1;
            StSubject.SelectedIndex = -1;


        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

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

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pck(object sender, EventArgs e)
        {
            if (guna2CircleButton2.Text ==">")
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

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            all a = new all();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            teacher a = new teacher();
            a.Show();
            this.Hide();
        }

       
        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            guna2Transition3.ShowSync(se);
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            string surov = "SELECT stId,stName as Name,stSurname as Surname, stGender as Gender,stDay as Day, stPhone as Phone, stVaqti as Vaqti,stSubject as Subject, stregistr as Registr from Student Where stName Like @Name+'%' ";
            SqlCommand sd = new SqlCommand(surov, s);
            sd.Parameters.AddWithValue("@Name",se.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sd;
            DataTable dt = new DataTable();
            dt.Clear();

           
            da.Fill(dt);
            StDataG.DataSource = dt;
           
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap im = new Bitmap(StDataG.Width, StDataG.Height);
            StDataG.DrawToBitmap(im, new Rectangle(0, 0, StDataG.Width, StDataG.Height));
            e.Graphics.DrawImage(im, 5, 10);
        }
    }
}
