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
    public partial class RegisterFrm : Form
    {
        public RegisterFrm()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection(@"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True");
        SqlCommand comm;

        private void ChkBoxShwPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxShwPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CBUserType.Text == "Admin")
            {
                String password = "Admin123";


                if (txtConfirmPassword.Text != password & txtConfirmPassword.Text != password)
                {
                    MessageBox.Show("Incorrect password for user type Admin");
                }
                else if (txtUsername.Text == "" & txtPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Username and password fields are empty", "Registration failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    conn.Open();
                    string register = "INSERT INTO LOGINDETAILS VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    comm = new SqlCommand(register, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                    MessageBox.Show("Your account has been Successfully Created", "Registration Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Passwords does not match, Please re-enter", "Registration failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();

                }

            }
            else if (CBUserType.Text == "Teacher")
            {
                if (txtUsername.Text == "" & txtPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Username and password fields are empty", "Registration failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    conn.Open();
                    string register = "INSERT INTO LOGINDETAILS VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    comm = new SqlCommand(register, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                    MessageBox.Show("Your account has been Successfully Created", "Registration Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Passwords does not match, Please re-enter", "Registration failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();

                }
            }

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            new LoginFrm().Show();
            this.Hide();
        }
    }
}
