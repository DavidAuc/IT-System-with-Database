//Hugo van Schalkwyk 31586872

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
    public partial class TextbookExchangeForm : Form
    {
        public TextbookExchangeForm()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(@"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True");
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public SqlDataReader dataReader;

        private void TextbookExchangeForm_Load(object sender, EventArgs e)
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
            //populate textbook combobox on handout
            conn.Open();

            cbbTextbooks.Items.Clear();
            cbbTextbooks.Text = "";
            cbbTextbooks.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM tblInventory WHERE InStock = 1", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbTextbooks.Items.Add(dataReader.GetValue(0));
            }

            conn.Close();

            //populate scholar combobox on handout
            conn.Open();

            cbbScholars.Items.Clear();
            cbbScholars.Text = "";
            cbbScholars.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM SCHOLAR", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbScholars.Items.Add(dataReader.GetValue(0));
            }

            conn.Close();

            //populate textbook combobox on recieve
            conn.Open();

            cbbRecieveTextbook.Items.Clear();
            cbbRecieveTextbook.Text = "";
            cbbRecieveTextbook.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM tblInventory WHERE InStock = 0", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbRecieveTextbook.Items.Add(dataReader.GetValue(0));
            }

            conn.Close();

            //populate scholar combobox on recieve
            conn.Open();

            cbbRecieveScholar.Items.Clear();
            cbbRecieveScholar.Text = "";
            cbbRecieveScholar.SelectedIndex = -1;

            comm = new SqlCommand("SELECT * FROM SCHOLAR", conn);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                cbbRecieveScholar.Items.Add(dataReader.GetValue(0));
            }

            conn.Close();
        }

        private void btnDisplayTextbooks_Click(object sender, EventArgs e)
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

        private void btnDisplayInventory_Click(object sender, EventArgs e)
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

        private void btnDisplayScholars_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM SCHOLAR", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "SCHOLAR");

                dgDisplay.DataSource = ds;
                dgDisplay.DataMember = "SCHOLAR";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayTextbooks2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM TEXTBOOK", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "TEXTBOOK");

                dgDisplayRecieve.DataSource = ds;
                dgDisplayRecieve.DataMember = "TEXTBOOK";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayInventory2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM tblInventory", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblInventory");

                dgDisplayRecieve.DataSource = ds;
                dgDisplayRecieve.DataMember = "tblInventory";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayScholars2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM SCHOLAR", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "SCHOLAR");

                dgDisplayRecieve.DataSource = ds;
                dgDisplayRecieve.DataMember = "SCHOLAR";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbTextbooks.SelectedIndex != -1 && cbbScholars.SelectedIndex != -1)
                {
                    DateTime myDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    //update inventory table
                    conn.Open();

                    comm = new SqlCommand($"UPDATE tblInventory SET InStock = 0 WHERE TextbookID = @num", conn);
                    comm.Parameters.AddWithValue("@num", cbbTextbooks.SelectedItem.ToString());
                    comm.ExecuteNonQuery();

                    conn.Close();

                    //insert trade date
                    conn.Open();

                    adap = new SqlDataAdapter();
                    comm = new SqlCommand($"INSERT INTO tblTradingDates(Textbook_ID, Scholar_ID, TradingDateOut) VALUES(@textNum,@scholNum,'{myDate.ToShortDateString()}')", conn);
                    comm.Parameters.AddWithValue("@textNum", cbbTextbooks.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@scholNum", cbbScholars.SelectedItem.ToString());
                    adap.InsertCommand = comm;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    loadCbb();

                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Please select a textbook and student to submit.");
                }
               
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbbScholars.SelectedIndex = -1;
            cbbScholars.Text = "";
            cbbTextbooks.Text = "";
            cbbTextbooks.SelectedIndex = -1;
        }

        private void btnDisplayTradingDates_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM tblTradingDates", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblTradingDates");

                dgDisplay.DataSource = ds;
                dgDisplay.DataMember = "tblTradingDates";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayTradingDates2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adap = new SqlDataAdapter();
                DataSet ds = new DataSet();

                comm = new SqlCommand($"SELECT * FROM tblTradingDates", conn);

                adap.SelectCommand = comm;
                adap.Fill(ds, "tblTradingDates");

                dgDisplayRecieve.DataSource = ds;
                dgDisplayRecieve.DataMember = "tblTradingDates";

                conn.Close();
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecieveSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbRecieveTextbook.SelectedIndex != -1 && cbbRecieveScholar.SelectedIndex != -1)
                {
                    DateTime myDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    //update inventory table
                    conn.Open();

                    comm = new SqlCommand($"UPDATE tblInventory SET InStock = 1 WHERE TextbookID = @num", conn);
                    comm.Parameters.AddWithValue("@num", cbbRecieveTextbook.SelectedItem.ToString());
                    comm.ExecuteNonQuery();

                    conn.Close();

                    //update trade date
                    conn.Open();

                    comm = new SqlCommand($"UPDATE tblTradingDates SET TradingDateIn = '{myDate.ToShortDateString()}' WHERE Scholar_ID = @num", conn);
                    comm.Parameters.AddWithValue("@num", cbbRecieveScholar.SelectedItem.ToString());
                    comm.ExecuteNonQuery();

                    conn.Close();

                    loadCbb();

                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Please select a textbook and student to submit.");
                }

            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnRecieveClear_Click(object sender, EventArgs e)
        {
            cbbRecieveScholar.SelectedIndex = -1;
            cbbRecieveScholar.Text = "";
            cbbRecieveTextbook.Text = "";
            cbbRecieveTextbook.SelectedIndex = -1;
        }
    }
}
