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
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void buttonEnrollmentSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into EnrollmentTable values (@StudentId,@StudentName,@EnrollmentDate,@Standard)", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxEnrollmentStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxEnrollmentStudentname.Text);
            cnn.Parameters.AddWithValue("@EnrollmentDate", dateTimePickerEnrollment.Text);
            cnn.Parameters.AddWithValue("Standard", textBoxEnrollmentStandard.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEnrollmentAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from EnrollmentTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void buttonEnrollmentUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update EnrollmentTable set studentname=@studentname, EnrollmentDate=@EnrollmentDate, Standard=@Standard where EnrollmentId=@EnrollmentId", con);
            cnn.Parameters.AddWithValue("@EnrollmentId", int.Parse(textBoxEnrollmentStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxEnrollmentStudentname.Text);
            cnn.Parameters.AddWithValue("@EnrollmentDate", dateTimePickerEnrollment.Text);
            cnn.Parameters.AddWithValue("@Standard", textBoxEnrollmentStandard.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEnrollmentDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete EnrollmentTable where EnrollmentId=@EnrollmentId", con);
            cnn.Parameters.AddWithValue("@EnrollmentId", int.Parse(textBoxEnrollmentStudentid.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEnrollmentNew_Click(object sender, EventArgs e)
        {
            textBoxEnrollmentStudentid.Text = "";
            textBoxEnrollmentStudentname.Text = "";
            textBoxEnrollmentStandard.Text = "";
        }

        private void buttonEnrollmentDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from EnrollmentTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
