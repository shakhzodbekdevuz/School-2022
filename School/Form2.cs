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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tolov();
        }
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\sDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void tolov()
        {

            string surov = "SELECT * from Tolov";
            SqlDataAdapter sd = new SqlDataAdapter(surov, s);
            SqlCommandBuilder bu = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            tdgw.DataSource = ds.Tables[0];
            s.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

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
                guna2Transition3.ShowSync(guna2ShadowPanel2);
                guna2CircleButton1.Text = "-";
            }
            else
            {
                guna2Transition3.HideSync(guna2ShadowPanel2);
                guna2CircleButton1.Text = "+";
            }
            guna2Transition3.HideSync(guna2TextBox4);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            guna2Transition3.ShowSync(guna2TextBox4);
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprn", 400, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
           
            if (name.Text == "" || familya.Text == "" || sub.SelectedIndex == -1 || databegin.Text == "" || dataend.Text == "" || summa.Text == "")
            {
                MessageBox.Show("Iltimos Hamma Ma'lumotni kiriting!");
            }
            else
            {

                s.Open();
                SqlCommand c = new SqlCommand("insert into Tolov(Tname,Tfamily,Tsub,Tbegindata,Tenddata,Tsumma) values (@tName,@tSurname,@tsub,@tDayb,@tdaye,@tsum)", s);
                c.Parameters.AddWithValue("@tName", name.Text);
                c.Parameters.AddWithValue("@tSurname", familya.Text);
                c.Parameters.AddWithValue("@tsub", sub.Text);
                c.Parameters.AddWithValue("@tDayb", databegin.Value.Date);
                c.Parameters.AddWithValue("@tdaye", dataend.Value.Date);
                c.Parameters.AddWithValue("@tsum", summa.Text);

                c.ExecuteNonQuery();
                s.Close();
                tolov();
                load a = new load(); a.Show();
            }
        }
        int K = 0;
        private void tdgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (K == 0)
            {
                MessageBox.Show("Iltimos tanlang");
            }
            else
            {


                s.Open();
                SqlCommand d = new SqlCommand("delete from Student where stId=@Stk", s);
                d.Parameters.AddWithValue("@Stk", K);
                d.ExecuteNonQuery();
                MessageBox.Show("Delete");
                tolov();
                s.Close();
            }
        }
        private void tdgw_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = tdgw.SelectedRows[0].Cells[1].Value.ToString();
            familya.Text = tdgw.SelectedRows[0].Cells[2].Value.ToString();
            sub.Text = tdgw.SelectedRows[0].Cells[3].Value.ToString();
            databegin.Text = tdgw.SelectedRows[0].Cells[4].Value.ToString();
            dataend.Text = tdgw.SelectedRows[0].Cells[5].Value.ToString();
            summa.Text = tdgw.SelectedRows[0].Cells[6].Value.ToString();
            if (name.Text == "")
            {
                K = 0;
            }
            else
            {
                K = Convert.ToInt32(tdgw.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            tolov();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            name.Text = "";
            familya.Text = "";
            sub.SelectedIndex = -1;
           
            summa.Text = "";
           
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            st a = new st();
            a.Show();
            this.Hide();
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            teacher a = new teacher();
            a.Show();
            this.Hide();
        }
        string pname, psur, ps, pbd, ped;

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
           all a = new all();
            a.Show();
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        int pos =60, psum;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NASAF ILM MASKANI", new Font("Century Gothis", 12, FontStyle.Bold), Brushes.Blue, new Point(100));
            e.Graphics.DrawString("To'lov Miqdori ", new Font("Century Gothis", 12, FontStyle.Bold), Brushes.Blue, new Point(26,40));
            foreach (DataGridViewRow row in tdgw.Rows)
            {
                int a = Convert.ToInt32(row.Cells["Id"].Value);
                if (a == K)
                {
                    pname = "" + (row.Cells["Tname"].Value);
                    psur = "" + row.Cells["Tfamily"].Value;
                    ps = "" + (row.Cells["Tsub"].Value);
                    pbd = "" + (row.Cells["Tbegindata"].Value);
                    ped = "" + (row.Cells["Tenddata"].Value);
                    psum = Convert.ToInt32(row.Cells["Tsumma"].Value);
                    e.Graphics.DrawString("Ism:", new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                    e.Graphics.DrawString("" + pname, new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(50, pos));
                    e.Graphics.DrawString("Familiya:", new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos + 20));
                    e.Graphics.DrawString("" + psur, new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(75, pos + 20));
                    e.Graphics.DrawString("Fan:" , new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos+40));
                    e.Graphics.DrawString("" + ps, new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(60, pos+40));
                    e.Graphics.DrawString("Sanadan" , new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(150, pos));
                    e.Graphics.DrawString("" + pbd, new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point( 220,pos));
                    e.Graphics.DrawString("Sanagacha", new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(150, pos + 20));
                    e.Graphics.DrawString("" + ped, new Font("Century Gothis", 8, FontStyle.Bold), Brushes.Blue, new Point(220, pos+20));
                   
                    pos = pos + 20;
                
                e.Graphics.DrawString("Total: " + psum+" ming so'm", new Font("Century Gothis", 12, FontStyle.Bold), Brushes.Blue, new Point(50, pos + 50));
                e.Graphics.DrawString("****************Nasaf ilm maskani****************", new Font("Century Gothis", 12, FontStyle.Bold), Brushes.Blue, new Point(10, pos + 70));

                pos = 100;}
            }
            
        }
    }
    }

