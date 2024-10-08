using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutomatedTellerMachine
    {
        int bankomatId;
        int avaliableMoney;
        string location;

        public int BankomatId
        {
            get { return bankomatId; }
            set { bankomatId = value; }
        }

        public int AvaliableMoney
        {
            get { return avaliableMoney; }
            set { avaliableMoney = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public AutomatedTellerMachine(int BankomatId, int AvaliableMoney, string Location)
        {

            bankomatId = BankomatId;
            avaliableMoney = AvaliableMoney;
            location = Location;
        }
    }
}
