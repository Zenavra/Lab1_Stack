using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Transactions
    {
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public Transactions(string description, int amount, DateTime date)
        {
            Description = description;
            Amount = amount;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date} - {Description}: {Amount} ₴";
        }
    }
}
