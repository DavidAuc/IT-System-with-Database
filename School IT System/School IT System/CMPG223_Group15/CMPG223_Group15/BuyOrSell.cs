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
    public partial class BuyOrSell : Form
    {
        public BuyOrSell()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True");
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public SqlDataReader dataReader;

        private void TextbookExchangeForm_Load(object sender, EventArgs e)
        {
           
        }
        private void BuyOrSell_Load(object sender, EventArgs e)
        {
            try
            {
                loadCbb();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void loadCbb()
        {
            //populate textbook combobox on sell
            conn.Open();

            cbbTextbooks.Items.Clear();
            cbbTextbooks.Text = "";
            cbbTextbooks.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM TEXTBOOK WHERE Amount_Sold IS NULL", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbTextbooks.Items.Add(dataReader.GetValue(0));
            }

            conn.Close();

            //populate textbook combobox on buy
            conn.Open();

            cbbAuthorRecieve.Items.Clear();
            cbbAuthorRecieve.Text = "";
            cbbAuthorRecieve.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM AUTHOR", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbAuthorRecieve.Items.Add(dataReader.GetValue(0));
            }
            conn.Close();
        }

        private void btnDisplayTextbooks_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM TEXTBOOK", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "TEXTBOOK");

                dgDisplay.DataSource = ds;
                dgDisplay.DataMember = "TEXTBOOK";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayInventory_Click_1(object sender, EventArgs e)//NOT USED
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM tblInventory", conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "tblInventory");
                dgDisplay.DataSource = ds;
                dgDisplay.DataMember = "tblInventory";
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayScholars2_Click(object sender, EventArgs e)
        {
            //REmove
        }

        private void btnSubmit_Click_1(object sender, EventArgs e) //EDIT --------------------------------------
        {
            try
            {
                if (cbbTextbooks.SelectedIndex != -1)
                {
                    DateTime myDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    decimal dAmount;
                    if (decimal.TryParse(tbAmountSold.Text, out dAmount))
                    {
                        //update textbook table
                        conn.Open();
                        comm = new SqlCommand($"UPDATE TEXTBOOK SET Date_Sold='" + myDate + "' WHERE Textbook_ID = @num", conn); //Update Date sold
                        comm.Parameters.AddWithValue("@num", cbbTextbooks.SelectedItem.ToString());
                        comm.ExecuteNonQuery();
                        comm = new SqlCommand($"UPDATE TEXTBOOK SET Amount_Sold='" + dAmount + "' WHERE Textbook_ID = @num", conn);//Update Amount Sold
                        comm.Parameters.AddWithValue("@num", cbbTextbooks.SelectedItem.ToString());
                        comm.ExecuteNonQuery();
                        conn.Close();
                        loadCbb();
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a textbook to sell.");
                }
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        } //-------------------------------------------

        private void btnRecieveSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime myDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                conn.Open();
                string ins = "INSERT INTO TEXTBOOK(Textbook_ID, Author_ID, Textbook_Name, Textbook_Condition, Date_Bought, Book_Price) VALUES(@tbTextbookID, @tbAuthorID, @tbTextbookName, @tbTextbookCondition, @tbDateBought, @tbBookPrice)";
                comm = new SqlCommand(ins, conn);
                comm.Parameters.AddWithValue("@tbTextbookID", tBoxID.Text);
                comm.Parameters.AddWithValue("@tbAuthorID", cbbAuthorRecieve.Text);
                comm.Parameters.AddWithValue("@tbTextbookName", tbTextbookName.Text);
                comm.Parameters.AddWithValue("@tbTextbookCondition", 10);
                comm.Parameters.AddWithValue("@tbDateBought", myDate);
                comm.Parameters.AddWithValue("@tbBookPrice", tbPrice.Text);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);              
            }
        }

        private void btnRecieveClear_Click(object sender, EventArgs e)
        {
            tBoxID.Text = "";
            cbbAuthorRecieve.Text = "";
            cbbAuthorRecieve.SelectedIndex = -1;
            tbTextbookName.Text = "";
            tbPrice.Text = "";
        }

        private void btnDisplayScholars_Click_1(object sender, EventArgs e)
        {
            //Remove
        }

        private void btnDisplayTradingDates_Click_1(object sender, EventArgs e)
        {
            //REmove
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            tbAmountSold.Text = "";
            cbbTextbooks.Text = "";
            cbbTextbooks.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTextbooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabHandout_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuyDisplayTextBook_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM TEXTBOOK", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "TEXTBOOK");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TEXTBOOK";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayAuthorsOnBuy_Click(object sender, EventArgs e) //Display Quthors on Buy tab
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                comm = new SqlCommand($"SELECT * FROM AUTHOR", conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "AUTHOR");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "AUTHOR";
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabRecieve_Click(object sender, EventArgs e)
        {

        }
    }
}
