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

namespace N
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        
        private void buttonAttendanceSave_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into AttendanceTable values (@StudentId,@StudentName,@Date,@Status,@Reason)", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStudentname.Text);
            cnn.Parameters.AddWithValue("@Date", dateTimePickerAttendance.Text);
            cnn.Parameters.AddWithValue("@Status", textBoxStatus.Text);
            cnn.Parameters.AddWithValue("Reason", textBoxReason.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAttendanceAdd_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from AttendanceTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void buttonAttendanceUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update AttendanceTable set StudentName=@StudentName,Date=@Date,Status=@Status,Reason=@Reason where StudentId=@StudentId", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStudentname.Text);
            cnn.Parameters.AddWithValue("@Date", dateTimePickerAttendance.Text);
            cnn.Parameters.AddWithValue("@Status", textBoxStatus.Text);
            cnn.Parameters.AddWithValue("@Reason", textBoxReason.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAttendanceDelete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete AttendanceTable where studentid=@studentid", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAttendanceNew_Click_1(object sender, EventArgs e)
        {
            textBoxStudentid.Text = "";
            textBoxStudentname.Text = "";
            textBoxStatus.Text = "";
            textBoxReason.Text = "";
        }

        private void buttonAttendanceDisplay_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from AttendanceTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}

