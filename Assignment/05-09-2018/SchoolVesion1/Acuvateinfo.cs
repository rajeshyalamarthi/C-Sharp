using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_09_2018
{
    public class Acuvateinfo
    {
       


       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to acuvate info");
            Console.WriteLine("Please Drop mentioned student details");
            int[] grades = new int[12];
            StudentDetails[] studentDetails = new StudentDetails[1000];
           

            for (int i = 0; i <= studentDetails.Length; i++)
            {
                studentDetails[i] = new StudentDetails();

                Console.WriteLine("Enter the first Name");
                studentDetails[i].FirstName = Console.ReadLine();

                Console.WriteLine("enter the last name");
                studentDetails[i].LastName = Console.ReadLine();
                Console.WriteLine("enter the Gender");
                studentDetails[i].Gender = Console.ReadLine();
                Console.WriteLine("enter studentId");
                studentDetails[i].StudentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Date of birth");
                studentDetails[i].DOB = Console.ReadLine();
                Console.WriteLine("Enter grade of the student");
                int G = Convert.ToInt32(Console.ReadLine());





                if (G >= 1 && G <= 12)
                {
                    studentDetails[i].Grade = G;

                    if (grades[studentDetails[i].Grade - 1] < 22)
                    {

                        grades[studentDetails[i].Grade - 1]++;
                    }

                    else

                        Console.WriteLine("limit exceeded");
                }




                else
                {
                    Console.WriteLine("Enter the grade with in the range 1-12");
                }

                Console.WriteLine("if you want to drop other student data? if yes press- 1..NO-press 0");

                int raj = Convert.ToInt32(Console.ReadLine());
                if (raj == 1)
                {
                    continue;
                }
                else if (raj == 0) {


                    for (int j = 0; j < grades.Length; j++)
                    {

                        Console.WriteLine("In {0} grade no.of students are {1} ", j + 1, grades[j]);

                        
                    }
                    Console.WriteLine("If you want add other student details? if yes press 1--else press 0 ");
                    int t=Convert.ToInt32(Console.ReadLine());
                    if (t == 1)
                    {
                        continue;
                    }
                    else if (t==0) { 
                        return;
                    }
                   
                }

              




                





            }
            
          

            
               
           
            
        }
    }
}
