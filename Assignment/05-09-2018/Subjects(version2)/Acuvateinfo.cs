using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05_09_2018b
{
    public class Acuvateinfo
    {
        static int i = 0;
        static Subject[] sub = new Subject[6];
        static StudentDetails[] studentDetailss = new StudentDetails[244];
        static int[] grades = new int[12];

        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t\t\t WELCOME TO ACUAVTE SCHOOLS");
            Console.WriteLine("\t\t\t\t\t\t **************************\n");
            
            for (int k = 0; k < 6; k++)
            { for (int l = 0; l < 1; l++)
                {
                    Console.WriteLine("enter the name of the subject ");
                    sub[k] =new Subject(); 
                    sub[k].SubjectName = Console.ReadLine();
                }

                
            }
            //for (i = 0; i <= studentDetailss.Length; i++)
            for (; i <= studentDetailss.Length; i++)
            {
                studentDetailss[i] = new StudentDetails();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter the first Name of student ");
                studentDetailss[i].FirstName = Console.ReadLine();
               
                Console.WriteLine("enter the last name of student ");
                studentDetailss[i].LastName = Console.ReadLine();
               
                Console.WriteLine("enter the Gender ");
                studentDetailss[i].Gender = Console.ReadLine();
                
                
                Console.WriteLine("enter studentId ");
                studentDetailss[i].StudentId = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Enter the Date of birth");
                studentDetailss[i].DOB = Console.ReadLine();
                
                Console.WriteLine("Enter grade of the student\n");
                int storesub = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("Enter the subject of the student");

                if (storesub >= 1 && storesub <= 12)
                {
                    studentDetailss[i].Grade = storesub;

                    if (grades[studentDetailss[i].Grade - 1] < 22)
                    {

                        grades[studentDetailss[i].Grade - 1]++;
                    }

                    else
                    {

                        Console.WriteLine("limit exceeded");
                    }
                }


                else
                {
                    Console.WriteLine("Enter the grade with in the range 1-12");
                }
                Console.WriteLine("------------------------------------------------------------------------------------\n");
                Console.WriteLine(" If you wnat to see the count of the grade press 0 || to enter student marks press 2" );

                int raj = Convert.ToInt32(Console.ReadLine());
                
                if (raj == 0)
                {


                    for (int j = 0; j < grades.Length; j++)
                    {

                        Console.WriteLine("In {0} grade no.of students are {1} ", j + 1, grades[j]);


                    }

                    Console.WriteLine("If you want to continue  press 1--else press 0 ");
                   
                }

                else if (raj == 2)
                {
                    
                    Console.WriteLine("enter the marks of the subject entered");
                    Console.WriteLine("--------------------------------------");
                    int[] storemark = new int[6];
                    for(int k=0; k < 6; k++)
                    {
                        if (storemark[k] >= 0 && storemark[k] <= 100)
                        {
                            for (int l = 0; l < 1; l++)
                            {
                                storemark[k] = int.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("you enterd out of range");
                            break;
                        }

                    }
                    for (int k = 0; k < 6; k++)
                    {
                        //for (int l = 0; l < 1; l++)
                        //{
                        
                            studentDetailss[i].marks[k] = storemark[k];
                            studentDetailss[i].Total = 0;
                            for (int p = 0; p < 6; p++)
                            {
                                studentDetailss[i].Total += studentDetailss[i].marks[p];
                            }                       
                    }

                    studentDetailss[i].Total = 0;
                    for(int k=0;k<6;k++)
                    {
                        studentDetailss[i].Total += studentDetailss[i].marks[k];
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("the total marks are "+studentDetailss[i].Total);

                    studentDetailss[i].percentage = ((studentDetailss[i].Total / 600) * 100);
                    Console.WriteLine("Percentage(%) is "+studentDetailss[i].percentage);
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\tGRADING");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("\n");

                    bool flag = true;
                    StudentDetails temp = new StudentDetails();

                    if (i == 0)
                    {
                        for (int loop = 0; loop < 6; loop++)
                        {
                            sub[loop].studentt = studentDetailss[i];
                            sub[loop].highestmark = studentDetailss[i].marks[loop];
                        }
                    }
                    else
                    {
                        for (int loop = 0; loop < 6; loop++)
                        {
                            if (studentDetailss[i].marks[loop] > sub[loop].highestmark)
                            {
                                sub[loop].studentt = studentDetailss[i];
                                sub[loop].highestmark = studentDetailss[i].marks[loop];

                            }
                        }
                    }

                    for (int l = 1; (l <(studentDetailss.Length-1)) && flag; l++)
                    {
                        flag = false;
                        for(int q= 0; q < (studentDetailss.Length - 1); q++)
                        {
                            if( studentDetailss[q] !=null && studentDetailss[q+1] !=null)
                            {
                                if(studentDetailss[q+1].percentage > studentDetailss[q].percentage )
                                {
                                    temp = studentDetailss[q];
                                    studentDetailss[q] = studentDetailss[q + 1];
                                    studentDetailss[q + 1] = temp;
                                    flag = true;
                                }
                            }
                        }

                    }
                    Console.WriteLine("Name\t\tRank\t\tPercentage");
                    int count = 1;
                    foreach (StudentDetails item in studentDetailss)
                    {
                       
                        if (item != null)
                        {

                            Console.WriteLine(item.FirstName + "\t\t" + count + "\t\t" + item.percentage);

                           
                        }
                        count++;
                    }
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("\n");

                    Console.WriteLine("\n\tStandings according to the marks Gained in each subject \n");

                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("Name\t Subject\t Marks");
                    foreach(Subject item in sub)
                    {
                        Console.WriteLine(item.studentt.FirstName+"\t\t"+item.SubjectName+"\t\t"+item.highestmark);
                    }

                    Console.WriteLine("to enter new  student details--press 3 // to exit print 4");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    int top = int.Parse(Console.ReadLine());
                    if (top == 3)
                    {
                        continue;
                    }
                    else if(top == 4)
                    {
                        break;
                    }

                }

            }

            }          
        }
    }

