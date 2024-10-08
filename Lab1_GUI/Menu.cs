using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_GUI
{
    public partial class Menu : Form
    {
        private Account[] _accounts;
        private Account _currentAcc;
        private Form1 _form1;
        private AutomatedTellerMachine[] _ATM;
        public Menu(Account[] accounts, Account currentAcc, Form1 form1, AutomatedTellerMachine[] ATM)
        {
            InitializeComponent();
            _accounts = accounts;
            _currentAcc = currentAcc;
            _form1 = form1;
            _ATM = ATM;
        }


        private void balanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Balance: {_currentAcc.Balance}" + "₴");
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            if (_currentAcc.Transactions != null)
            {
                History history = new History(_currentAcc);
                history.Show();
            }
            else
            {
                MessageBox.Show("Your history is empty!");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            menuWithdraw withDraw = new menuWithdraw(_currentAcc);
            withDraw.Show();
        }
        private void transferButton_Click(object sender, EventArgs e)
        {
            menuTransfer MoneyTransfer = new menuTransfer(_accounts, _currentAcc);
            MoneyTransfer.Show();
        }

        private void nearestButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            MessageBox.Show("Nearest ATM through: " + random.Next(100, 600) + " meters");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _form1.Show();
        }

        private void ATMInfoButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] Banks = new string[3];
            Banks[0] = "PrivatBank";
            Banks[1] = "OschadBank";
            Banks[2] = "SenseBank";
            MessageBox.Show("Name of Bank: " + Banks[random.Next(0, 2)] + "\nATM ID: " + _ATM[random.Next(0, 3)].BankomatId + "\nLocation: " + _ATM[random.Next(0, 3)].Location);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        
    }
}
