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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void dateTimePickerdob_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerdob.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePickerdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePickerdob.CustomFormat = "";
            }
        }

        private void buttonStudentSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into StudentTable values (@StudentId,@StudentName,@Dob,@Gender,@Phone,@Email)", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStudentname.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePickerdob.Text);
            cnn.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
            cnn.Parameters.AddWithValue("@Phone", textBoxPhonenumber.Text);
            cnn.Parameters.AddWithValue("Email", textBoxEmail.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from StudentTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewStudent.DataSource = table;

        }

        private void buttonStudentUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update StudentTable set studentname=@studentname,dob=@dob,gender=@gender,phone=@phone,email=@email where studentid=@studentid", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStudentname.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePickerdob.Text);
            cnn.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
            cnn.Parameters.AddWithValue("@Phone", textBoxPhonenumber.Text);
            cnn.Parameters.AddWithValue("@Email", textBoxEmail.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStudentDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete StudentTable where studentid=@studentid", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStudentid.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStudentNew_Click(object sender, EventArgs e)
        {
            textBoxStudentid.Text = "";
            textBoxStudentname.Text = "";
            comboBoxGender.Text = "None";
            textBoxPhonenumber.Text = "";
            textBoxEmail.Text = "";

        }

        private void buttonStudentDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from StudentTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewStudent.DataSource = table;
        }
    }
}