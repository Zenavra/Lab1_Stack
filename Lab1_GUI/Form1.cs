using System.Text;
using ClassLibrary;

namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        private static Account[] accounts;
        private static AutomatedTellerMachine[] ATM;
        private static bool isInitialized = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxPIN_TextChanged(object sender, EventArgs e)
        {
            textBoxPIN.PasswordChar = '*';
            textBoxPIN.MaxLength = 4;
        }

        private void textBoxNUM_TextChanged(object sender, EventArgs e)
        {
            textBoxNUM.MaxLength = 19;
            int cursorPosition = textBoxNUM.SelectionStart;
            string text = textBoxNUM.Text.Replace(" ", "");
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
            if (textBoxNUM.Text != newText)
            {
                textBoxNUM.Text = newText;
                textBoxNUM.SelectionStart = cursorPosition + (newText.Length - text.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isInitialized)
            {
                accounts = new Account[5];
                accounts[0] = new Account("1111 2222 3333 4444", "Pavel Sergeev", 100, 1234);
                accounts[1] = new Account("2222 3333 4444 5555", "Muhhamed Ali", 12345, 2345);
                accounts[2] = new Account("3333 4444 5555 6666", "Benjamine Button", 54230, 3456);
                accounts[3] = new Account("4444 5555 6666 7777", "Leron Baron", 300, 4567);
                accounts[4] = new Account("5555 6666 7777 8888", "Walter White", 50000, 5678);

                ATM = new AutomatedTellerMachine[3];
                ATM[0] = new AutomatedTellerMachine(51241, 100000, "Polubotka street 32");
                ATM[1] = new AutomatedTellerMachine(76232, 256822, "Ivana Mazepy street 54");
                ATM[2] = new AutomatedTellerMachine(12345, 865436, "Peremohy avenue 23");

                isInitialized = true;
            }

            Account currentAcc = new Account("", "", 0, 0);

            for (int i = 0; i < accounts.Length; i++)
            {
                if (textBoxNUM.Text == accounts[i].CardId && int.Parse(textBoxPIN.Text) == accounts[i].Password)
                {
                    textBoxNUM.Text = "";
                    textBoxPIN.Text = "";
                    this.Hide();
                    currentAcc = accounts[i];
                    Menu mainMenu = new Menu(accounts, currentAcc, this, ATM);
                    mainMenu.Show();
                    return;
                }
                else
                {
                    if (i == accounts.Length - 1)
                    {
                        MessageBox.Show("Wrong password or card number!");
                        textBoxPIN.Text = "";
                        return;
                    }
                }
            }
        }
                
    }
}
