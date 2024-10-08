using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bank
    {
        string bankName;
        public List<int> Bankomat { get; set; }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public Bank()
        {
            Bankomat = new List<int>();
        }
    }
}
