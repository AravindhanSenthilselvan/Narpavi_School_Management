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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoading1.Width += 1;
            if (panelLoading1.Width > 966)
            {
                timer1.Stop();
                Brand brand = new Brand();
                brand.Show();
                this.Hide();
                
            }
            
        }

      
        private void panelLoading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLoading1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
