using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice.Example2_IFE_
{
    class IncorrectInputFormat
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public void Method1()
        {
            try
            {
                Console.WriteLine("Enter the Name Of the Employee");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Person ID");
                EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Employee Details are {0} {1}",Name,EmployeeId);

            }
            catch(Exception e1)
            {
                Console.WriteLine("May be incorrect Input Format");
                throw e1;
            }
            finally
            {
                Console.WriteLine("Clean Up Memory");
            }
        }

        public void Method2()
        {
           
            try
            {
                Method1();
                Console.WriteLine("Error May  from Input Validation");
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("May be incorrect Input Format for Method2");
              
            }
            finally
            {
                Console.WriteLine("Clean Up Memory for method2");
            }
        }
    }
}
