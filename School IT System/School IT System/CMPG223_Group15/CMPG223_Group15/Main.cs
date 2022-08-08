//Heinrich Conradie, 27469352
//Hugo van Schalkwyk, 31586872
//David Aucamp, 33484112
//Adriaan Louw, 33768080
//Marnus Enslin, 32377630 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Group15
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseMaintenanceForm dbForm = new DataBaseMaintenanceForm();
            dbForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports dbFormReport = new Reports();
            dbFormReport.ShowDialog();

        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            TextbookExchangeForm ExchangeForm = new TextbookExchangeForm();
            ExchangeForm.ShowDialog();
        }

        private void btnBuySell_Click(object sender, EventArgs e)
        {
            BuyOrSell BuyForm = new BuyOrSell();
            BuyForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginFrm LoginForm = new LoginFrm();
            LoginForm.ShowDialog();
            this.Close();
        }
    }
}
