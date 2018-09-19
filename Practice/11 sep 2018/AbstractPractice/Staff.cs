using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
     class Staff:Employee
    {
        public string DepartmentName { get; set; }

    //    public abstract void GetHEllo();
        public override void GetSalary()
        {
            Console.WriteLine("\nenter the name of staff");
            Name = Console.ReadLine();
            Console.WriteLine("enter id of an Staffemployee");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter department name");
            DepartmentName = Console.ReadLine();
            Console.WriteLine("enter salary of an staffperson");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("No special packages--Salary is:"+Salary);
        }

    }
}
