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
    public partial class Standard : Form
    {
        public Standard()
        {
            InitializeComponent();
        }

        private void buttonStandardStudentSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into StandardTable values (@StudentId,@StudentName,@Standard)", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStandardStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStandardStudentname.Text);
            cnn.Parameters.AddWithValue("@Standard", textBoxStandard.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStandardStudentAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from StandardTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewStandard.DataSource = table;
        }

        private void buttonStandardStudentUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update StandardTable set studentname=@studentname,Standard=@Standard where studentid=@studentid", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStandardStudentid.Text));
            cnn.Parameters.AddWithValue("@StudentName", textBoxStandardStudentname.Text);
            cnn.Parameters.AddWithValue("@Standard", textBoxStandard.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStandardStudentDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete StandardTable where studentid=@studentid", con);
            cnn.Parameters.AddWithValue("@StudentId", int.Parse(textBoxStandardStudentid.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStandardStudentNew_Click(object sender, EventArgs e)
        {
            textBoxStandardStudentid.Text = "";
            textBoxStandardStudentname.Text = "";
            textBoxStandard.Text = "";
        }

        private void buttonStandardStudentDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from StandardTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewStandard.DataSource = table;
        }
    }
}
