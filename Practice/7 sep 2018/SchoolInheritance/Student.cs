using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInheritance
{
   public class Student:PersonalInfo
    {
       public int Rank;
       public int Totalmarks;

        public Student(string Name,int rank,int totalmarks,int age, int  DOB):base(Name,age,DOB)
        {

            Rank = rank;
            Totalmarks = totalmarks;
           // PrintStudent();
            
        }
        public override void CheckOverride()
        {
 
            Console.WriteLine("-----------is"+Name+""+Age);
        }

        //public void PrintStudent()
        //{
        //    Console.WriteLine("the student details are Name-{0}\n Rank is--{1}\n Total marks are-{2}\n Age of the student is-{3}\n Date of birth of the student is-{4}",Name,Rank,Totalmarks,Age,_DOBYear);
        //}

    }
}
