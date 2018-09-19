using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_2108
{
    class SalesMan : Employee
    {
        public string WorksCity { get; set; }
        public float Commission { get; set; }
        public float CSalary { get; set; }
        public override void GetSalary()
        {
            Console.WriteLine("\nenter the name of an salesman");
            Name = Console.ReadLine();
            Console.WriteLine("enter id of an employee");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary of salesman");
            Salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the commission of the salesman");
            Commission = Convert.ToSingle(Console.ReadLine());
            CSalary = Salary + Commission;

            Console.WriteLine("\nThe salary of sales man Excluding Bonus is :" + CSalary);
        }

        public override void GetBonus(float bonus)
        { 
            if (CSalary == 0)
            {
                throw new EmployeeException("Total Salary cannot be Zero {0}", 0);
            }
           else if ((CSalary / 10) < bonus)
            {
                throw new EmployeeException(" As Mentioned Bonus should not be Greater than 10 percent of Salary-(Bonus <{0})", (CSalary / 10));
            }

            else
            {
                Console.WriteLine("\nSalary Including Bonus is {0}:", CSalary + bonus);
              
            }
                
            }
           
        }
    }

