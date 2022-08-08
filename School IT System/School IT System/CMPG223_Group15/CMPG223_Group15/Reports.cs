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
using System.IO;


namespace CMPG223_Group15
{
    public partial class Reports : Form
    {
        private
     
            string conStr = @"Data Source=ADRIAAN\SQLEXPRESS;Initial Catalog=CMPG223_Group15_TextBookDB;Integrated Security=True";
            SqlConnection conn;
            SqlCommand comm;
            SqlDataAdapter adap;
            DataSet ds;
            ///SqlDataReader theReader;

            String sFormLanguage = "English"; ///SET EQUAL TO PUB VARIABLE
            String sReportType = "";

        public Reports()
        {
            InitializeComponent();
        }

        private void btnLanguageSwitch_Click(object sender, EventArgs e) //Language Toggle
        {

            if (sFormLanguage == "English")
            {              
                sFormLanguage = "Afrikaans";
                SwitchLanguage();
            }
            else // Switch to English
            
            {
                sFormLanguage = "English";
                SwitchLanguage();
            }

        }

        private void SwitchLanguage() //Method that changes the overall language of the UI
        {
            if (sFormLanguage == "English") //English
            {
                lblReportType.Text = "Report Type:";
                comboboxReportType.Items.Clear();
                comboboxReportType.Items.Add("Events in time period");
                comboboxReportType.Items.Add("Sate of the Textbook Management System");
                lblStartDate.Text = "Pick an Start Date:";
                lblEndDate.Text = "Pick an End Date:";
                cbIncludeTotals.Text = "Include totals in report: "; 
                btnExit.Text = "&Close";
                btnLanguageSwitch.Text = "Skakel oor na Afrikaans";
                btnExport.Text = "Save Report";
                btnGenerate.Text = "Generate Report";
                cbTotalState.Text = "Include totals in report:";


            }
            else // Afrikaans
            {
                lblReportType.Text = "Verslag Tipe:";               
                comboboxReportType.Items.Clear();
                comboboxReportType.Items.Add("Stelselgebeurtenisse");
                comboboxReportType.Items.Add("Toestand van handboekbestuurstelsel");
                lblStartDate.Text = "Kies 'n begindatum:";
                lblEndDate.Text = "Kies 'n einddatum:";
                cbIncludeTotals.Text = "Sluit totale in die verslag in: ";              
                btnExit.Text = "&Gaan Terug";
                btnLanguageSwitch.Text = "Switch to English";
                btnExport.Text = "Stoor verslag";
                btnGenerate.Text = "Genereer Verslag";
                cbTotalState.Text = "Sluit totale in die verslag in:";
            }
        }


        private void Reports_Load(object sender, EventArgs e) //Form Load
        {
            SwitchLanguage();
            lbOutput.Items.Clear();
            cbIncludeTotals.Checked = !true;
            cbTotalState.Checked = !true;
            pnlEvents.Visible = !true;
            pnlState.Visible = !true;
            sReportType = "";

        }

        private void comboboxReportType_SelectedIndexChanged(object sender, EventArgs e) //Select type of Report
        {
            if (comboboxReportType.SelectedIndex == 0) //System Events
            {
                pnlEvents.Visible = true;
                pnlState.Visible = !true;
                sReportType = "Events";
            }
            else //State of System
            {
                pnlEvents.Visible = !true;
                pnlState.Visible = true;
                sReportType = "State";
            }
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int SQLCount(string sQuery)
        {
            try //Count rows of querys
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                ds = new DataSet();
                adap = new SqlDataAdapter();
                comm = new SqlCommand(sQuery, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds);
                int iCount = ds.Tables[0].Rows.Count;
                conn.Close();
                return iCount;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return 0;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            if (sReportType == "Events") //System Events---------------------------------------
            {
                string sStartDate = dtpStart.Text;
                string sEndDate = dtpEnd.Text;

                if (sFormLanguage == "English") //English Report
                {
                    try 
                    {
                        int iTransactionCount, iBooksBoughtCount, iBooksSoldCount, iFineCount, iTotalTransactions, iTotalBought, iTotalSold, iTotalFines;
                        //SQL DB
                        iTransactionCount = SQLCount($"SELECT * FROM GIVEORRETRIEVE WHERE Date BETWEEN '" + sStartDate + "' AND '" + sEndDate + "'"); //Transaction Count
                        iBooksBoughtCount = SQLCount($"SELECT * FROM TEXTBOOK WHERE Date_Bought BETWEEN '" + sStartDate + "' AND '" + sEndDate + "'"); //BooksBoughtCount
                        iBooksSoldCount = SQLCount($"SELECT * FROM TEXTBOOK WHERE Date_Sold BETWEEN '" + sStartDate + "' AND '" + sEndDate +"'"); //BooksSoldCount
                        iFineCount = SQLCount($"SELECT * FROM FINING WHERE Fining_Date BETWEEN '" + sStartDate + "' AND '" + sEndDate + "'"); //Fine Count
                                                                                                                                      //Output of Event Counts
                        lbOutput.Items.Add("System Summary Report of Events in the period of " + dtpStart.Text + " to " + dtpEnd.Text);
                        lbOutput.Items.Add("Date of Report \t:" + DateTime.Now.ToString("dddd,dd MMMM yyyy"));
                        lbOutput.Items.Add("");
                        lbOutput.Items.Add("Number of events in the time period:");
                        lbOutput.Items.Add("Amount of tranactions: \t" + iTransactionCount);
                        lbOutput.Items.Add("Amount of Books Bought: \t" + iBooksBoughtCount);
                        lbOutput.Items.Add("Amount of Books Sold: \t" + iBooksSoldCount);
                        lbOutput.Items.Add("Amount of Fines: \t\t" + iFineCount);
                        lbOutput.Items.Add("");
                        //SQL for Totals
                        if (cbIncludeTotals.Checked)
                        {
                            iTotalTransactions = SQLCount("SELECT * FROM GIVEORRETRIEVE"); // Total Transactions
                            iTotalBought = SQLCount("SELECT * FROM TEXTBOOK "); //Counts Total Books;
                            iTotalSold = SQLCount("SELECT * FROM TEXTBOOK WHERE Date_Sold IS NOT NULL"); //Total Books Sold Count;
                            iTotalFines = SQLCount("SELECT * FROM FINING"); //Total Fine Count;
                                                                             //Output
                            lbOutput.Items.Add("Total transaction on database: \t\t" + iTotalTransactions);
                            lbOutput.Items.Add("Total amount of books bought on database: \t" + iTotalBought);
                            lbOutput.Items.Add("Total amount of books sold on database: \t" + iTotalSold);
                            lbOutput.Items.Add("Total amount of fines on database: \t\t" + iTotalFines);
                        }
                        lbOutput.Items.Add("");
                        lbOutput.Items.Add("END OF REPORT");
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);                       
                    }
                }
                else { } //Afrikaans Report
            }
            else if (sReportType == "State") //State of System-------------------------
            {
                if (sFormLanguage == "English") //English Report
                {
                    try
                    {
                        int iStudentBooks, iInventoryBooks, iLostBooks, iTotalBooks, iTotalStudents, iTotalTeachers;
                        //SQL DB
                        iStudentBooks = SQLCount("SELECT * FROM GIVEORRETRIEVE WHERE Type='give'"); //Books held by Students
                        iInventoryBooks = SQLCount("SELECT * FROM tblInventory WHERE inStock='true'"); //Books in Inventory
                        iLostBooks = SQLCount("SELECT * FROM FINING"); //Lost Books
                                                                        //Output
                        lbOutput.Items.Add("State of the System Report");
                        lbOutput.Items.Add("Date of Report \t:" + DateTime.Now.ToString("dddd,dd MMMM yyyy"));
                        lbOutput.Items.Add("");
                        lbOutput.Items.Add("Books in Inventory: \t" + iInventoryBooks);
                        lbOutput.Items.Add("Books held by students: \t" + iStudentBooks);
                        lbOutput.Items.Add("Lost Books: \t\t" + iLostBooks);
                        if (cbTotalState.Checked)
                        { //SQL Totals
                            iTotalBooks = SQLCount("SELECT * FROM TEXTBOOK"); //Total Books
                            iTotalStudents = SQLCount("SELECT * FROM SCHOLAR"); //Total Students
                            iTotalTeachers = SQLCount("SELECT * FROM TEACHER"); //Total Teachers
                            //Output of Totals
                            lbOutput.Items.Add("");
                            lbOutput.Items.Add("Total Books in the system: \t\t" + iTotalBooks);
                            lbOutput.Items.Add("Total Teachers on the system: \t" + iTotalStudents);
                            lbOutput.Items.Add("Total Students on the system: \t" + iTotalTeachers);
                            //Maths
                            if (iTotalBooks>0)
                            {
                                lbOutput.Items.Add("");
                                 // % of  books held by students
                                 lbOutput.Items.Add("Precentage of textbooks held by students: \t" + ((iStudentBooks / iTotalBooks) * 100) + "%");
                            }
                        }
                        lbOutput.Items.Add("");
                        lbOutput.Items.Add("END OF REPORT");
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else { }  //Afrikaans Report
            }
            else
            {
                if (sFormLanguage == "English") //Exception: No Report type selected
                {
                    MessageBox.Show("Please select a Report Type. ");
                }
                else
                {
                    MessageBox.Show("Kies 'n tipe verslag.");
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e) //Saves Report in listbox as text file
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            
            if (sFormLanguage == "English") //English Report
            {
                saveFileDialog1.Title = "Save Text File";
            }
            else //Afrikaans Report
            {
                saveFileDialog1.Title = "Stoor tekslêer";
            }
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Summary_Report_" + DateTime.Now.ToString("dddd,ddMMMMyyyy");
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string path = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(path, lbOutput.Items.Cast<string>().ToArray());
                MessageBox.Show("File saved");
            }            
        }
    }

}
