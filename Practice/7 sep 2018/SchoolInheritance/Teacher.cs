using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInheritance
{
  public class Teacher:PersonalInfo
    {
      public int MinNoOfWorkingHours;
        public int Salary;
        int[] Subjects = new int[3];

        public Teacher(string Name,int MinNoOfWorkingHours,int age, int DOB,int salary,int[] sub):base(Name,age,DOB)
        {
            this.MinNoOfWorkingHours = MinNoOfWorkingHours;
            Salary = salary;
            Subjects = sub;
            GetTeacher();
        }
        public void GetTeacher()
        {
            Console.WriteLine("the Teacher details are MinNoOfWorkingHours-{0}\n Age-{1}\n DOB{2}\n Salary{3}\n {4}Subjects", MinNoOfWorkingHours,Age,_DOBYear,Salary,Subjects);
        }
    }
}
