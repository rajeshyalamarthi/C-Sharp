using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInheritance
{
    public class PersonalInfo
    {
       // public string Name;
        public int _age;
        public int _DOBYear;
        //private string v1;
        //private int v2;

        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Please enter the age with in the range");
                }
            }
        }
        

        public int DOB {
            get {return _DOBYear; }
            set {value=_DOBYear; }
        }

        public PersonalInfo(string name,int cage,int cDOB)
        {
            Name = name;
            Age = cage;
            _DOBYear = cDOB;
        }

    

        public virtual void CheckOverride()
        {
            //this.Name =Name;
            //    this.Age = Age;

            Console.WriteLine("name is {0} and age is {1}",Name,Age);
        }

        //public virtual void CheckOverride2()
        //{
            
        //}


    }
    public class program{ 


        static void Main(string[] args)
        {
            //Console.WriteLine("Enter thestudent Name:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter rank of the student");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter total marks");
            //int c= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter age of the student");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Enter the date of birth of the student");
            //int e = Convert.ToInt32(Console.ReadLine());


            //Student student = new Student(a,b,c,d,e);


            //Console.WriteLine("Enter the teacher Name:");
            //string z = Console.ReadLine();
            //Console.WriteLine("Enter min no of working hours");
            //int x = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine("enter age of the teacher");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Enter the date of birth of the teacher");
            //int w = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter age of the teacher");
            //int v = Convert.ToInt32(Console.ReadLine());

            ////  int[] r = Convert.ToInt32(Console.ReadLine());
            //int[] sub = { 1, 2, 3 };

            ////Teacher teacher = new Teacher(z,x,y,w,v, sub);
            //PersonalInfo pb = new PersonalInfo("rajesh", 33, 33);

            //pb.CheckOverride();

            Student str = new Student("suresh", 2, 22, 21, 1992);
            str.CheckOverride();





            //Teacher teacher = new Teacher();




        }
    }
}
