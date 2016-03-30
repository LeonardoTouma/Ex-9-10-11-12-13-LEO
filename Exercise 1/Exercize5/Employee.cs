using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize7
{
    class Employee
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string SocialsSecurityNumber { get; private set; }
        public int Hourlywage { get; private set; }

        public Employee(string firstname, string lastname, string socialsecuritynumber, int Hourlywage)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.SocialsSecurityNumber = socialsecuritynumber;
            this.Hourlywage = Hourlywage;
        }
        public void AddEmployee ()
        {
            List<string> employeeList = new List<string>(); 

            foreach (var worker in employeeList)
            {
                
            }
        }
    }
}
