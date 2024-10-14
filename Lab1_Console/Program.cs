using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using ClassLibrary;
using Lab1_Console;


namespace Lab1_Console
{
    internal class ProgramConsole
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[5];
            AutomatedTellerMachine[] ATM = new AutomatedTellerMachine[5];

            accounts[0] = new Account("1111 2222 3333 4444", "Pavel Sergeev", 100, 1234);
            accounts[1] = new Account("2222 3333 4444 5555", "Muhhamed Ali", 12345, 2345);
            accounts[2] = new Account("3333 4444 5555 6666", "Benjamine Button", 54230, 3456);
            accounts[3] = new Account("4444 5555 6666 7777", "Leron Baron", 300, 4567);
            accounts[4] = new Account("5555 6666 7777 8888", "Walter White", 50000, 5678);

            ATM[0] = new AutomatedTellerMachine(1, 1234219850, "Polubotka street");
            ATM[1] = new AutomatedTellerMachine(2, 1231, "Ivana Mazepy street");
            ATM[2] = new AutomatedTellerMachine(3, 12, "Honcha street");
            ATM[3] = new AutomatedTellerMachine(4, 1239853, "Peremohy avenue");
            ATM[4] = new AutomatedTellerMachine(5, 1249854, "Red square");

            string cardNumber;
            int cardPin;
            int attempts = 3;
            int withdrawAmount;
            int transferAmount;


            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Enter card number:");
                cardNumber = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < accounts.Length; i++)
                {

                    if (cardNumber == accounts[i].CardId)
                    {
                        Console.WriteLine("Enter PIN: ");
                        cardPin = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (cardPin == accounts[i].Password)
                        {
                            Console.WriteLine("You are entered in account");
                            Console.WriteLine();

                            while (true)
                            {
                                Console.WriteLine("1.Check balance\n2.Check history\n3.Withdrawing\n4.Money transfer\n5.Check near ATM\n6.Info about ATM\n0.Exit");
                                Console.WriteLine();
                                int choice = int.Parse(Console.ReadLine());

                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("Your balance is: " + accounts[i].Balance + "uah");
                                        Console.WriteLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Choose history option:\n1. Last Day\n2. Last 7 days\n3. Last 30 days");
                                        Console.WriteLine();
                                        int historyChoice = int.Parse(Console.ReadLine());
                                        if (historyChoice == 1)
                                        {
                                            if (accounts[i].Transactions.Count == 0)
                                            {
                                                Console.WriteLine("Today's transactions history is empty!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Today's transactions:");
                                                Console.WriteLine();
                                                foreach (var transaction in accounts[i].Transactions)
                                                {
                                                    Console.WriteLine(transaction.ToString());
                                                }
                                            }
                                        }
                                        else if (historyChoice == 2)
                                        {
                                            int operAmount = random.Next(3, 7);
                                            string[] operations = { "Withdraw:", "Money transfer:" };
                                            Console.WriteLine("Transactions for last 7 days:");
                                            Console.WriteLine();
                                            for (int k = 0; k < operAmount; k++)
                                            {
                                                DateTime randomDate = DateTime.Now.AddDays(random.Next(-7, 0));
                                                Console.WriteLine($"{randomDate.ToShortDateString()} - {operations[random.Next(0, 2)]} {random.Next(0, 10000)}uah");
                                            }
                                            Console.WriteLine();
                                        }
                                        else if (historyChoice == 3)
                                        {
                                            int operAmount = random.Next(7, 15);
                                            string[] operations = { "Withdraw:", "Money transfer:" };
                                            Console.WriteLine("Transactions for last 30 days:");
                                            Console.WriteLine();
                                            for (int l = 0; l < operAmount; l++)
                                            {
                                                DateTime randomDate = DateTime.Now.AddDays(random.Next(-30, 0));
                                                Console.WriteLine($"{randomDate.ToShortDateString()} - {operations[random.Next(0, 2)]} {random.Next(0, 10000)}uah");
                                            }
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice!");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter the withdrawal amount");
                                        Console.WriteLine();
                                        withdrawAmount = int.Parse(Console.ReadLine());
                                        if (withdrawAmount > accounts[i].Balance)
                                        {
                                            Console.WriteLine("Error! There are not enough funds on your balance to make a withdrawal");
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Successful withdrawal. Don't forget to pick up your card.");
                                            Console.WriteLine();
                                            accounts[i].Balance -= withdrawAmount;
                                            accounts[i].Transactions.Add(new Transactions("Withdrawal", withdrawAmount, DateTime.Now));
                                        }
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter card id:");
                                        cardNumber = Console.ReadLine();
                                        for (int j = 0; j < accounts.Length; j++)
                                        {
                                            if (cardNumber == accounts[j].CardId)
                                            {
                                                Console.WriteLine("Enter the tranfer amount");
                                                transferAmount = int.Parse(Console.ReadLine());

                                                if (transferAmount < accounts[i].Balance)
                                                {
                                                    accounts[i].Balance -= transferAmount;
                                                    accounts[j].Balance += transferAmount;

                                                    accounts[i].Transactions.Add(new Transactions("Money transfer", transferAmount, DateTime.Now));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There are not enough funds on the balance");
                                                    Console.WriteLine();
                                                }
                                            }
                                            if (j == accounts.Length)
                                            {
                                                Console.WriteLine("This card isn`t exsist!");
                                                Console.WriteLine();
                                            }
                                        }
                                        break;
                                    case 5:
                                        for (int x = 0; x < 3; x++)
                                        {
                                            int ranATM = random.Next(0, 4);
                                            Console.WriteLine(ATM[ranATM].Location);
                                        }
                                        break;
                                    case 6:
                                        string[] Banks = new string[3];
                                        Banks[0] = "PrivatBank";
                                        Banks[1] = "OschadBank";
                                        Banks[2] = "SenseBank";
                                        Console.WriteLine("\nName of Bank: " + Banks[random.Next(0, 2)] + "\nATM ID: " + ATM[random.Next(0, 3)].BankomatId + "\nLocation: " + ATM[random.Next(0, 3)].Location + "\n");
                                        break;
                                    case 0:
                                        goto End;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong password");
                            Console.WriteLine();
                            attempts--;
                            Console.WriteLine("You have " + attempts + " attempts left to enter your password or your card will be blocked.");
                            Console.WriteLine();
                            i--;
                            if (attempts == 0)
                            {
                                Console.WriteLine("Your card has been blocked!");
                                Console.WriteLine();
                                return;
                            }
                        }
                    }
                    if (i == accounts.Length)
                    {
                        Console.WriteLine("This card isn`t exsist!");
                        Console.WriteLine();
                    }
                }
            End:;
            }
        }
    }
}