using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeViaVirtual
{
    class SalesMan:Employee
    {
        public string WorksCity { get; set; }
        public double Commission { get; set; }

        public override void GetSalary()
        {
            Console.WriteLine("\nenter the name of an salesman");
            Name = Console.ReadLine();
            Console.WriteLine("enter id of an employee");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary of salesman");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the commission of the salesman");
            Commission = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nThe salary of sales man is" + (Salary + Commission));
        }

    }
}
