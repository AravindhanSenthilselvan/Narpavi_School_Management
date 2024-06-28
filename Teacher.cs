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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }



        private void buttonTeacherAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from TeacherTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewTeacher.DataSource = table;
        }

        private void buttonTeacherSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into TeacherTable values (@TeacherId,@TeacherName,@Dob,@Gender,@Phone,@Email)", con);
            cnn.Parameters.AddWithValue("@TeacherId", int.Parse(textBoxTeacherid.Text));
            cnn.Parameters.AddWithValue("@TeacherName", textBoxTeachername.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePickerTeacherdob.Text);
            cnn.Parameters.AddWithValue("@Gender", comboBoxTeacherGender.Text);
            cnn.Parameters.AddWithValue("@Phone", textBoxTeacherPhonenumber.Text);
            cnn.Parameters.AddWithValue("Email", textBoxTeacherEmail.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePickerTeacherdob_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTeacherdob.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePickerTeacherdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePickerTeacherdob.CustomFormat = "";
            }
        }

        private void buttonTeacherUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update TeacherTable set Teachername=@Teachername,dob=@dob,gender=@gender,phone=@phone,email=@email where Teacherid=@Teacherid", con);
            cnn.Parameters.AddWithValue("@TeacherId", int.Parse(textBoxTeacherid.Text));
            cnn.Parameters.AddWithValue("@TeacherName", textBoxTeachername.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePickerTeacherdob.Text);
            cnn.Parameters.AddWithValue("@Gender", comboBoxTeacherGender.Text);
            cnn.Parameters.AddWithValue("@Phone", textBoxTeacherPhonenumber.Text);
            cnn.Parameters.AddWithValue("@Email", textBoxTeacherEmail.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonTeacherDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete TeacherTable where TeacherId=@TeacherId", con);
            cnn.Parameters.AddWithValue("@TeacherId", int.Parse(textBoxTeacherid.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonTeacherNew_Click(object sender, EventArgs e)
        {
            textBoxTeacherid.Text = "";
            textBoxTeachername.Text = "";
            comboBoxTeacherGender.Text = "None";
            textBoxTeacherPhonenumber.Text = "";
            textBoxTeacherEmail.Text = "";
        }

        private void buttonTeacherDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from TeacherTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewTeacher.DataSource = table;
        }
    }
}
