using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visade_av_Lärare
{
    class Account1
    {
        // Kod snippets t.ex. prop/propfull halv och hel propertys sedan tab tab

        public string ID { get; set; }
        private int myVar;
        //En vanlig konstruktor jobbar på samma sätt men tvingar inte på användaren specifika värden men att skriva in värden i en konstruktor så att det inte är en default tvingar.
        public Account1()
        {
            _balance = "kent";
            this.balanceName = "Nord";
                this.Name = Name;
        }
        public string balance
        {
            get { return balance; }
            set { balance = value; }
        }
        // Man kan höger klicka på ett ord och trycka in rename eller ctrl R och sedan ändra allt med samma namn
        //Kan använda _ efter en privat klass varibel som _balance under
        private int _balance;
        public void DepositMoney (int accountNumber, int amount = 100)
        {
            _balance += amount;
        }
    }
}
