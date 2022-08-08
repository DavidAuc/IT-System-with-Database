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

namespace CMPG223_Group15
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True");
        SqlCommand comm;
        SqlDataAdapter adap;

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM LOGINDETAILS WHERE UserName= '" + txtUsername.Text + "' and PassWord= '" + txtpassword.Text + "'";
            comm = new SqlCommand(login, conn);
            SqlDataReader dr = comm.ExecuteReader();

            String password = "Admin123";

            if (txtpassword.Text == password)
            {
                if (dr.Read() == true)
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, Please Try Agian", "Login Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtpassword.Text = "";
                    txtUsername.Focus();
                }

            }
            else
            {
                if (dr.Read() == true)
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, Please Try Agian", "Login Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtpassword.Text = "";
                    txtUsername.Focus();
                }
            }

            conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            new RegisterFrm().Show();
            this.Hide();
        }

        private void ChkBoxShwPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxShwPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }
        }
    }
}
