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
    public partial class menuWithdraw : Form
    {
        private Account _currentAcc;
        public menuWithdraw(Account currentAcc)
        {
            InitializeComponent();
            _currentAcc = currentAcc;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > 0)
            {
                if (int.Parse(textBox1.Text) < _currentAcc.Balance)
                {
                    _currentAcc.Balance -= int.Parse(textBox1.Text);
                    _currentAcc.AddTransaction("Withdrawal", int.Parse(textBox1.Text));
                    MessageBox.Show("Success!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Not enough money!");
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("ERROR!");
                textBox1.Text = "";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
