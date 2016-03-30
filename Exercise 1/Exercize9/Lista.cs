using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize18
{
    class Lista
    {
       
            List<Employee> employeeList = new List<Employee>();

        public void AddEmployee(Employee worker)
        {
           
                employeeList.Add(worker);
        }
        public bool RemoveEmployee(string ssn)
        {
            bool result = false;
            for (int i = 0; i < employeeList.Count; i++)
            {
                
                if (ssn == employeeList[i].SocialsSecurityNumber)
                {
                    employeeList.Remove(employeeList[i]);
                    result =  true;
                    Console.WriteLine("Det finns en person med detta Ssn:et ");
                    break;
                }
                else
                {
                    Console.WriteLine("Det finns ingen med detta Ssn:et");
                }
            }
            //if (employee != null)
            //{
            //    employees.Remove(empoloyeeToRemove)
            //}
            return result;

        }
        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }
    }
}
