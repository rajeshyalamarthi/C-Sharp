using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
        
         manager.GetSalary();

            SalesMan salesMan = new SalesMan();
          
            salesMan.GetSalary();

            Staff staff = new Staff();
            staff.GetSalary();

            
        }
    }
}
