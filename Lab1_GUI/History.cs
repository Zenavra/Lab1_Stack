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
    public partial class History : Form
    {
        private Account _currentAcc;
        public History(Account currentAcc)
        {
            InitializeComponent();
            _currentAcc = currentAcc;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dayButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (_currentAcc.Transactions.Count == 0)
            {
                listBox1.Items.Add("Today transactions history  is empty!");
            }
            foreach (var transaction in _currentAcc.Transactions)
            {
                listBox1.Items.Add(transaction.ToString());
            }
        }

        private void weekButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            int operAmount = random.Next(3, 7);

            string[] operations = new string[2];
            operations[0] = "Withdraw:";
            operations[1] = "Money transfer:";

            for (int i = 0; i < operAmount; i++)
            {
                DateTime currentDate = DateTime.Now;

                int daysBefore = -7;
                int daysAfter = 0;

                int randomDays = random.Next(daysBefore, daysAfter + 1);

                DateTime randomDate = currentDate.AddDays(randomDays);
                listBox1.Items.Add(randomDate + " - " + operations[random.Next(0, 2)] + " " + random.Next(0, 10000) + "₴");
            }
        }
       
        private void monthButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            int operAmount = random.Next(7, 15);
            for (int i = 0; i < operAmount; i++)
            {
                string[] operations = new string[2];
                operations[0] = "Withdraw:";
                operations[1] = "Money transfer:";

                DateTime currentDate = DateTime.Now;

                int daysBefore = -30;
                int daysAfter = 0;

                int randomDays = random.Next(daysBefore, daysAfter + 1);

                DateTime randomDate = currentDate.AddDays(randomDays);

                listBox1.Items.Add(randomDate + " - " + operations[random.Next(0, 2)] + " " + random.Next(0, 10000) + "₴");
            }
        }
    }
}
