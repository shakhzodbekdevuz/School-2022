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
    public partial class load : Form
    {
        public load()
        {
            
            InitializeComponent();
        }

        private void load_Load(object sender, EventArgs e)
        {
        timer1.Start();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            q.AutoStart = true;


            if (start == 30)
            {
                start = 0;
                timer1.Stop();
                
                this.Hide();

            }
        }
    }
}
