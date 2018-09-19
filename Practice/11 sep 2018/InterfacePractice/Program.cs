using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetcarDetails();

           
            car.GetSpeedInKmperhr();

            Console.WriteLine("\n\n");
            car.GetDistanceInKM();

            Console.WriteLine("\n\n");
            car.GetTimeInHrs();


            Console.WriteLine("These are Even");

            ISix six = new EvenOdd();
            six.Two();
            six.Four();
            six.Six();

            Console.WriteLine("\n\nThese are Odd");
            IFive five = new EvenOdd();
            five.One();
            five.Three();
            five.Five();
        }
    }
}
