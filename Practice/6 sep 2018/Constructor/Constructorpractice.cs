using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   
        public class vehicle
        {
            public string Name;
            public double speed;
            public double cost;
            public int time;

            public void GetDetials()
            {
                Console.WriteLine("{0} is driving car of cost Rs{1} with speed of {2}km/hr at {3}AM", Name, cost, speed, time);
            }

            public void one(double dup)
            {
                speed = speed + dup;


            }
            public void two(int dup1)
            {
                time = time + dup1;
            }

        //public void print()
        //{
            
        //}


            public class Program
            {

                static void Main(string[] args)
                {

                Constructor3 constructor3 = new Constructor3(5);
              //  Constructor3 constructor2 = new Constructor3(20,"micky");


                    //vehicle vehicle = new vehicle();
                    //vehicle.cost = 190000;
                    //vehicle.Name = "Rajesh";
                    //vehicle.speed = 200;
                    //vehicle.time = 5;

                    //for (int i = 0; i < 5; i++)
                    //{
                    //    vehicle.one(10);
                    //    vehicle.two(1);
                    //    vehicle.GetDetials();
                    //}
                    //Console.ReadLine();
                }
            }
        }
    }


