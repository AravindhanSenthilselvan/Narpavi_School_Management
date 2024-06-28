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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Teacher tr = new Teacher();
            tr.Show();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            Subject sj = new Subject();
            sj.Show();
        }

        private void buttonStandard_Click(object sender, EventArgs e)
        {
            Standard std = new Standard();
            std.Show();
        }

        private void buttonEnrollment_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance();
            att.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard dsh = new AdminDashboard();
            dsh.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
