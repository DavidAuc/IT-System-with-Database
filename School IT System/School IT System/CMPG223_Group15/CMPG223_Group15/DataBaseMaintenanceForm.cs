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
    public partial class DataBaseMaintenanceForm : Form
    {

        // Declaration for all tabs

        string conStr = @"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True";

        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        

        

        public DataBaseMaintenanceForm()
        {
            InitializeComponent();
        }

        // Start of AUTHOR Tab ...

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM AUTHOR";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewAuthor.DataSource = ds;
                dgViewAuthor.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO AUTHOR(Author_ID, Author_Name, Author_Surname) VALUES(@id, @name, @surname)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@id", tBoxAuthorInsertAuthorID.Text);
                comm.Parameters.AddWithValue("@name", tBoxAuthorInsertAuthorName.Text);
                comm.Parameters.AddWithValue("@surname", tBoxAuthorInsertAuthorSurname.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM AUTHOR";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewAuthor.DataSource = ds;
                dgViewAuthor.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();


                string upd = "UPDATE AUTHOR  SET Author_Name = @name, Author_Surname = @surname Where Author_ID = @id";
                comm = new SqlCommand(upd, conn);
                comm.Parameters.AddWithValue("@name", tBoxAuthorUpdateAuthorName.Text);
                comm.Parameters.AddWithValue("@surname", tBoxAuthorUpdateAuthorSurname.Text);
                comm.Parameters.AddWithValue("@id", tBoxAuthorUpdateAuthorID.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM AUTHOR WHERE Author_ID = @id";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@id", int.Parse(tBoxAuthorDeleteAuthorID.Text));
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
         
        }

        private void butAuthorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of AUTHOR Tab...



        // Start of TEXTBOOK Tab...

        private void butTextBookDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM TEXTBOOK";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewTextBook.DataSource = ds;
                dgViewTextBook.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
       
        }

        private void butTextBookRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM TEXTBOOK";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewTextBook.DataSource = ds;
                dgViewTextBook.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
       
        }

        private void butTextbookInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO TEXTBOOK(Textbook_ID, Author_ID, Textbook_Name, Textbook_Condition, Date_Bought, Book_Price, Date_Sold, Amount_Sold) VALUES(@tbTextbookID, @tbAuthorID, @tbTextbookName, @tbTextbookCondition, @tbDateBought, @tbBookPrice, @tbDateSold, @tbAmountSold)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@tbTextbookID", tBoxTextbookInsertTextbookID.Text);
                comm.Parameters.AddWithValue("@tbAuthorID", tBoxTextbookInsertAuthorID.Text);
                comm.Parameters.AddWithValue("@tbTextbookName", tBoxTextbookInsertTextbookName.Text);
                comm.Parameters.AddWithValue("@tbTextbookCondition", tBoxTextbookInsertTextbookCondition.Text);
                comm.Parameters.AddWithValue("@tbDateBought", tBoxTextbookInsertDateBought.Text);
                comm.Parameters.AddWithValue("@tbBookPrice", tBoxTextbookInsertBookPrice.Text);
                comm.Parameters.AddWithValue("@tbDateSold", tBoxTextbookInsertDateSold.Text);
                comm.Parameters.AddWithValue("@tbAmountSold", tBoxTextbookInsertAmountSold.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void butTextBookUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE TEXTBOOK SET Author_ID = @tbAuthorID, Textbook_Name = @tbTextbookName, Textbook_Condition = @tbTextbookCondition, Date_Bought = @tbDateBought, Book_Price = @tbBookPrice, Date_Sold = @tbDateSold, Amount_Sold = @tbAmountSold Where Textbook_ID = @tbTextbookID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@tbTextbookID", tBoxTextbookUpdateTextbookID.Text);
                comm.Parameters.AddWithValue("@tbAuthorID", tBoxTextbookUpdateAuthorID.Text);
                comm.Parameters.AddWithValue("@tbTextbookName", tBoxTextbookUpdateTextbookName.Text);
                comm.Parameters.AddWithValue("@tbTextbookCondition", tBoxTextbookUpdateTextbookCondition.Text);
                comm.Parameters.AddWithValue("@tbDateBought", tBoxTextbookUpdateDateBought.Text);
                comm.Parameters.AddWithValue("@tbBookPrice", tBoxTextbookUpdateBookPrice.Text);
                comm.Parameters.AddWithValue("@tbDateSold", tBoxTextbookUpdateDateSold.Text);
                comm.Parameters.AddWithValue("@tbAmountSold", tBoxTextbookUpdateAmountSold.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
    
        }

        private void butTextbookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM TEXTBOOK WHERE Textbook_ID = @tbTextbookID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@tbTextbookID", tBoxTextbookDeleteTextbookID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

           
        }
        private void butTextbookExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of TEXTBOOK Tab



        // Start of GIVEORRETRIEVE Tab

        private void butGORDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM GIVEORRETRIEVE";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewGOR.DataSource = ds;
                dgViewGOR.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
   
        }

        private void butGORRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM GIVEORRETRIEVE";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewGOR.DataSource = ds;
                dgViewGOR.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void butGORInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO GIVEORRETRIEVE(GiveOrRetrieve_ID, Textbook_ID, Scholar_ID, Teacher_ID, Type, Date) VALUES(@gorGiveOrRetrieveID, @gorTextbookID, @gorScholarID, @gorTeacherID, @gorType, @gorDate)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@gorGiveOrRetrieveID", tBoxGORInsertGiveOrRetrieveID.Text);
                comm.Parameters.AddWithValue("@gorTextbookID", tBoxGORInsertTextbookID.Text);
                comm.Parameters.AddWithValue("@gorScholarID", tBoxGORInsertScholarID.Text);
                comm.Parameters.AddWithValue("@gorTeacherID", tBoxGORInsertTeacherID.Text);
                comm.Parameters.AddWithValue("@gorType", tBoxGORInsertType.Text);
                comm.Parameters.AddWithValue("@gorDate", tBoxGORInsertDate.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
     
        }

        private void butGORUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE GIVEORRETRIEVE SET Textbook_ID = @gorTextbookID, Scholar_ID = @gorScholarID, Teacher_ID = @gorTeacherID, Type = @gorType, Date = @gorDate  Where GiveOrRetrieve_ID = @gorGiveOrRetrieveID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@gorGiveOrRetrieveID", tBoxGORUpdateGiveOrRetrieveID.Text);
                comm.Parameters.AddWithValue("@gorTextbookID", tBoxGORUpdateTextbookID.Text);
                comm.Parameters.AddWithValue("@gorScholarID", tBoxGORUpdateScholarID.Text);
                comm.Parameters.AddWithValue("@gorTeacherID", tBoxGORUpdateTeacherID.Text);
                comm.Parameters.AddWithValue("@gorType", tBoxGORUpdateType.Text);
                comm.Parameters.AddWithValue("@gorDate", tBoxGORUpdateDate.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void butGORDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM GIVEORRETRIEVE WHERE GiveOrRetrieve_ID = @gorGiveOrRetrieveID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@gorGiveOrRetrieveID", tBoxGORDeleteGiveOrRetrieveID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of GIVEORRETRIEVE Tab



        // Start of SCHOLAR Tab

        private void butScholarDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM SCHOLAR";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewScholar.DataSource = ds;
                dgViewScholar.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
         
        }

        private void butScholarRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM SCHOLAR";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewScholar.DataSource = ds;
                dgViewScholar.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void butScholarInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO SCHOLAR(Scholar_ID, Scholar_Name, Scholar_Surname, Scholar_Grade) VALUES(@scScholarID, @scScholarName, @scScholarSurname, @scScholarGrade)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@scScholarID", tBoxScholarInsertScholarID.Text);
                comm.Parameters.AddWithValue("@scScholarName", tBoxScholarInsertScholarName.Text);
                comm.Parameters.AddWithValue("@scScholarSurname", tBoxScholarInsertScholarSurname.Text);
                comm.Parameters.AddWithValue("@scScholarGrade", tBoxScholarInsertScholarGrade.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
          
        }

        private void butScholarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE SCHOLAR SET Scholar_Name = @scScholarName, Scholar_Surname = @scScholarSurname, Scholar_Grade = @scScholarGrade Where Scholar_ID = @scScholarID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@scScholarID", tBoxScholarUpdateScholarID.Text);
                comm.Parameters.AddWithValue("@scScholarName", tBoxScholarUpdateScholarName.Text);
                comm.Parameters.AddWithValue("@scScholarSurname", tBoxScholarUpdateScholarSurname.Text);
                comm.Parameters.AddWithValue("@scScholarGrade", tBoxScholarUpdateScholarGrade.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void butScholarDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM SCHOLAR WHERE Scholar_ID = @scScholarID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@scScholarID", tBoxScholarUpdateScholarID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            
        }

        private void butScholarExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of SCHOLAR Tab



        // Start of FINING Tab


        private void butFiningDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM FINING";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewFining.DataSource = ds;
                dgViewFining.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void butFiningRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM FINING";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewFining.DataSource = ds;
                dgViewFining.DataMember = "SourceTable";
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
      
        }

        private void butFiningInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO FINING(Fining_ID, Scholar_ID, Fining_Amount, Fining_Date) VALUES(@fnFiningID, @fnScholarID, @fnFiningAmount, @fnFiningDate)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@fnFiningID", tBoxFiningInsertFiningID.Text);
                comm.Parameters.AddWithValue("@fnScholarID", tBoxFiningInsertScholarID.Text);
                comm.Parameters.AddWithValue("@fnFiningAmount", tBoxFiningInsertFiningAmount.Text);
                comm.Parameters.AddWithValue("@fnFiningDate", tBoxFiningInsertFiningDate.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
         
        }

        private void butFiningUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE FINING SET Scholar_ID = @fnScholarID, Fining_Amount = @fnFiningAmount, Fining_Date = @fnFiningDate Where Fining_ID = @fnFiningID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@fnFiningID", tBoxFiningUpdateFiningID.Text);
                comm.Parameters.AddWithValue("@fnScholarID", tBoxFiningUpdateScholarID.Text);
                comm.Parameters.AddWithValue("@fnFiningAmount", tBoxFiningUpdateFiningAmount.Text);
                comm.Parameters.AddWithValue("@fnFiningDate", tBoxFiningUpdateFiningDate.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void butFiningDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM FINING WHERE Fining_ID = @fnFiningID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@fnFiningID", tBoxFiningDeleteFiningID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
  
        }
        private void butFiningExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of FINING Tab



        // Start of TEACHER Tab

        private void butTeacherDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM TEACHER";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewTeacher.DataSource = ds;
                dgViewTeacher.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
         
        }

        private void butTeacherRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM TEACHER";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewTeacher.DataSource = ds;
                dgViewTeacher.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
          
        }

        private void butTeacherInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO TEACHER(Teacher_ID, Subject_ID, Teacher_Name, Teacher_Surname) VALUES(@tcTeacherID, @tcSubject_ID, @tcTeacherName, @tcTeacherSurname)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@tcTeacherID", tBoxTeacherInsertTeacherID.Text);
                comm.Parameters.AddWithValue("@tcSubject_ID", tBoxTeacherInsertSubjectID.Text);
                comm.Parameters.AddWithValue("@tcTeacherName", tBoxTeacherInsertTeacherName.Text);
                comm.Parameters.AddWithValue("@tcTeacherSurname", tBoxTeacherInsertTeacherSurname.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
         
        }

        private void butTeacherUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE TEACHER SET Subject_ID = @tcSubject_ID, Teacher_Name = @tcTeacherName, Teacher_Surname = @tcTeacherSurname Where Teacher_ID = @tcTeacherID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@tcTeacherID", tBoxTeacherUpdateTeacherID.Text);
                comm.Parameters.AddWithValue("@tcSubject_ID", tBoxTeacherUpdateSubjectID.Text);
                comm.Parameters.AddWithValue("@tcTeacherName", tBoxTeacherUpdateTeacherName.Text);
                comm.Parameters.AddWithValue("@tcTeacherSurname", tBoxTeacherUpdateTeacherSurname.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void butTeacherDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM TEACHER WHERE Teacher_ID = @tcTeacherID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@tcTeacherID", tBoxTeacherDeleteTeacherID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
          
        }
        private void butTeacherExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // End of TEACHER Tab



        // Start of SUBJECT Tab


        private void butSubjectDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM SUBJECT";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewSubject.DataSource = ds;
                dgViewSubject.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void butSubjectRefresh_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM SUBJECT";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewSubject.DataSource = ds;
                dgViewSubject.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void butSubjectInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO SUBJECT(Subject_ID, Teacher_ID, Subject_Name) VALUES(@sjSubjectID, @sjTeacher_ID, @sjSubjectName)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@sjSubjectID", tBoxSubjectInsertSubjectID.Text);
                comm.Parameters.AddWithValue("@sjTeacher_ID", tBoxSubjectInsertTeacherID.Text);
                comm.Parameters.AddWithValue("@sjSubjectName", tBoxSubjectInsertSubject.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
                 
        }

        private void butSubjectUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE SUBJECT SET Teacher_ID = @sjTeacher_ID, Subject_Name = @sjSubjectName Where Subject_ID = @sjSubjectID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@sjSubjectID", tBoxSubjectUpdateSubjectId.Text);
                comm.Parameters.AddWithValue("@sjTeacher_ID", tBoxSubjectUpdateTeacherID.Text);
                comm.Parameters.AddWithValue("@sjSubjectName", tBoxSubjectUpdateSubject.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void butSubjectDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM SUBJECT WHERE Subject_ID = @sjSubjectID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@sjSubjectID", tBoxSubjectDeleteSubjectID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
          
        }

        private void butSubjectExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // End of SUBJECT Tab



        // Start of LOGINDETAILS Tab


        private void butLDDisplay_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM LOGINDETAILS";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewLD.DataSource = ds;
                dgViewLD.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
    

        private void butLDRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM LOGINDETAILS";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewLD.DataSource = ds;
                dgViewLD.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void butLDInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO LOGINDETAILS(UserName, PassWord) VALUES(@ldUserName, @ldPassWord)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@ldUserName", tBoxLDInsertUserName.Text);
                comm.Parameters.AddWithValue("@ldPassWord", tBoxLDInsertPassWord.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void butLDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE LOGINDETAILS SET PassWord = @ldPassWord Where  UserName = @ldUserName";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@ldUserName", tBoxLDUpdateUserName.Text);
                comm.Parameters.AddWithValue("@ldPassWord", tBoxLDUpdatePassWord.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void butLDDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM LOGINDETAILS WHERE UserName = @ldUserName";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@ldUserName", tBoxLDDeleteUserName.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
   
        private void butLDExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // End of LOGINDETAILS Tab



        // Start of tblInventory Tab


       

        private void buttblInventoryDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM tblInventory";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewtblInventory.DataSource = ds;
                dgViewtblInventory.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblInventoryRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM tblInventory";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewtblInventory.DataSource = ds;
                dgViewtblInventory.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblInventoryInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO tblInventory(TextbookID, Textbook_Name, InStock) VALUES(@itTextbookID, @itTextbookName, @itInStock)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@itTextbookID", tBoxtblIInsertTextbookID.Text);
                comm.Parameters.AddWithValue("@itTextbookName", tBoxtblIInsertTextbookName.Text);
                comm.Parameters.AddWithValue("@itInStock", tBoxtblIIInStock.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblInventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE tblInventory SET Textbook_Name = @itTextbookName, InStock = @itInStock Where TextbookID = @itTextbookID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@itTextbookID", tBoxtblIUpdateTextbookID.Text);
                comm.Parameters.AddWithValue("@itTextbookName", tBoxtblIUpdateTextbookName.Text);
                comm.Parameters.AddWithValue("@itInStock", tBoxtblIUpdateInStock.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblInventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM tblInventory WHERE TextbookID = @itTextbookID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@itTextbookID", tBoxtblDeleteTextbookID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of tblInventory Tab



        // Start of tblTradingDate Tab

        private void buttblTDDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM tblTradingDates";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewtblTD.DataSource = ds;
                dgViewtblTD.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblTDRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM tblTradingDates";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dgViewtblTD.DataSource = ds;
                dgViewtblTD.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblTDInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                string ins = "INSERT INTO tblTradingDates(Textbook_ID, Scholar_ID, TradingDateIn, TradingDateOut) VALUES(@tdTextbookID, @tdScholarID, @tdTradingDateIn, @tdTradingDateOut)";
                comm = new SqlCommand(ins, conn);

                comm.Parameters.AddWithValue("@tdTextbookID", tBoxtblTDInsertTextbookID.Text);
                comm.Parameters.AddWithValue("@tdScholarID", tBoxtblTDInsertScholarID.Text);
                comm.Parameters.AddWithValue("@tdTradingDateIn", tBoxtblTDInsertTradeDateIn.Text);
                comm.Parameters.AddWithValue("@tdTradingDateOut", tBoxtblTDInsertTradingDateOut.Text);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data successfuly inserted, refresh to see changes!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblTDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                string upd = "UPDATE tblTradingDates SET Scholar_ID = @tdScholarID, TradingDateIn = @tdTradingDateIn, TradingDateOut = @tdTradingDateOut Where Textbook_ID = @tdTextbookID";
                comm = new SqlCommand(upd, conn);

                comm.Parameters.AddWithValue("@tdTextbookID", tBoxtblTDUpdateTextbookID.Text);
                comm.Parameters.AddWithValue("@tdScholarID", tBoxtblTDUpdateScholarID.Text);
                comm.Parameters.AddWithValue("@tdTradingDateIn", tBoxtblTDUpdateTradingDateIn.Text);
                comm.Parameters.AddWithValue("@tdTradingDateOut", tBoxtblTDUpdateTradingDateOut.Text);

                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly updated, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblTDDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string del = "DELETE FROM tblTradingDates WHERE Textbook_ID = @tdTextbookID";
                comm = new SqlCommand(del, conn);
                comm.Parameters.AddWithValue("@tdTextbookID", tBoxtblTDDeleteTextbookID.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Data successfuly deleted, refresh to see changes!");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttblTDExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // End of tblTradingDate Tab

        // End Of Form
    }
}
