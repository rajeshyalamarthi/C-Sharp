using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_2108
{
    class Program
    {
        public static int NoofEmployeeDetailsToBeEnterd;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of employee details to be enterd");
            NoofEmployeeDetailsToBeEnterd = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= NoofEmployeeDetailsToBeEnterd; i++)
            {
                try
                {
                    SalesMan salesMan = new SalesMan();
                    salesMan.GetSalary();
                    if (salesMan.CSalary == 0)
                    {
                        salesMan.GetBonus(salesMan.Bonus);
                    }
                    else
                    {
                        Console.WriteLine("Enter bonus for Employee which should be less than-{0}(10% of Employee Salary)", salesMan.CSalary / 10);
                        salesMan.Bonus = Convert.ToSingle(Console.ReadLine());
                        salesMan.GetBonus(salesMan.Bonus);
                    }
                }
                catch (EmployeeException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("If you want to enter other Employee Details please press '1'else press 0 to exit");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        } } }