using System.Transactions;

namespace ClassLibrary
{
    public class Account
    {
        string cardId;
        string name;
        int balance;
        int password;
        public List<Transactions> Transactions { get; set; }

        public string CardId
        {
            get { return cardId; }
            set { cardId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public Account(string CardId, string Name, int Balance, int Password)
        {

            cardId = CardId;
            name = Name;
            balance = Balance;
            password = Password;
            Transactions = new List<Transactions>();
        }

        
        public void AddTransaction(string description, int amount)
        {
            Transactions.Add(new Transactions(description, amount, DateTime.Now));
        }

        public Account checkCardNum(Account[] accounts, string cardNubmer)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].CardId == cardNubmer)
                {
                    return accounts[i];
                }
            }
            return null;
        }
    }
}
