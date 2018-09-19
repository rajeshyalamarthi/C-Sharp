using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_2108
{
    class Manager : Employee
    {
        public string HODOf { get; set; }
        public double Stocks { get; set; }

        public override void GetSalary()
        {
            Console.WriteLine("\nenter the name of an Manager");
            Name = Console.ReadLine();
            Console.WriteLine("enter id of an employee");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary of Emoloyee");
            Salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the stocks of the employee");
            Stocks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("manager salary is{0}", Salary + (Stocks * 10));
        }
    }
}
