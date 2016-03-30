using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercize1
{
    class Person
    {
        public Person(string firstname, string lastname)
        {
            this.newFirstName = firstname;
            this.newLastName = lastname;
           
        }

        public string newFirstName
        {
            get { return newFirstName; }
            set { newFirstName = value; }
        }
        

        public string newLastName
        {
            get { return newLastName; }
            set { newLastName = value; }
        }


        public void GetFullName ()
        {
            Console.WriteLine(newFirstName + newLastName, newFirstName + newLastName);
        }
    }
}
