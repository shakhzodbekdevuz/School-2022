using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace School
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            p.Value = start;
            l.Text = start + "%";
            if (start < 30)
            {
                l.ForeColor = Color.Blue;
            }
            else
            {
                if (start > 70)
                {
                    l.ForeColor = Color.Red;
                }
                else { l.ForeColor = Color.Purple; }
                
            }
            if (p.Value == 100)
            {
                p.Value = 0;
                timer1.Stop();
                Form1 a = new Form1();
                a.Show();
                this.Hide();

            }
            
        }

        private void l_Click(object sender, EventArgs e)
        {

        }
    }
}
