using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;



namespace N
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PCMULCEBA-W11\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Encrypt=False");
            con.Open();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            SqlCommand cnn = new SqlCommand("select Username,Password from logintable where Username='" + textBoxUsername.Text + "'and Password='" + textBoxPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Main mn = new Main();
                mn.Show();

            }
            else
            {
                MessageBox.Show("Invaid Username or Password");
            }
            con.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLoginpage_Click(object sender, EventArgs e)
        {

        }
    }
}
