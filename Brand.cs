using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace N
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void panelLoading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerbrand_Tick(object sender, EventArgs e)
        {
            panelbrand.Width += 2;
            if (panelbrand.Width > 500)
            {
                timerbrand.Stop();
                this.Close();
                Login Lg = new Login();
                Lg.Show();
            }
            
        }
    }
}
