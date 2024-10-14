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
    public partial class menuTransfer : Form
    {
        private Account[] _accounts;
        private Account _currentAcc;
        public menuTransfer(Account[] accounts, Account currentAcc)
        {
            InitializeComponent();
            _accounts = accounts;
            _currentAcc = currentAcc;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _accounts.Length; i++)
            {
                if (textBox1.Text == _accounts[i].CardId && textBox1.Text != _currentAcc.CardId)
                {
                    if (int.Parse(textBox2.Text) <= 0)
                    {
                        MessageBox.Show("ERROR! Incorrect withdrawal amount!");
                        textBox2.Text = "";
                        return;
                    }
                    else
                    {
                        if (int.Parse(textBox2.Text) < _currentAcc.Balance)
                        {
                            _currentAcc.Balance -= int.Parse(textBox2.Text);
                            _accounts[i].Balance += int.Parse(textBox2.Text);
                            _currentAcc.AddTransaction("Money Transfer", int.Parse(textBox2.Text));
                            MessageBox.Show("Success!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Not enough money!");
                            textBox2.Text = "";
                        }
                        return;
                    }
                }
                else
                {
                    if (i == _accounts.Length - 1)
                    {
                        MessageBox.Show("Wrong card number!");
                        textBox1.Text = "";
                        return;
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 19;
            int cursorPosition = textBox1.SelectionStart;
            string text = textBox1.Text.Replace(" ", "");
            StringBuilder formattedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                formattedText.Append(text[i]);
                if ((i + 1) % 4 == 0 && (i + 1) != text.Length)
                {
                    formattedText.Append(' ');
                }
            }
            string newText = formattedText.ToString();
            if (textBox1.Text != newText)
            {
                textBox1.Text = newText;
                textBox1.SelectionStart = cursorPosition + (newText.Length - text.Length);
            }

        }

        
    }
}
