using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
   public class Car:ICar
    {
        public string Name { get; set; }
        public string ModelNo { get; set; }
        public string Color { get; set; }
        public double  Speed { get; set; }
        public double DistanceinKM { get; set; }
        public double hours { get; set; }

        public void GetcarDetails()
        {
            Console.WriteLine("Enter BrandName of the car");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the ModelNo of the car");
            ModelNo = Console.ReadLine();
            Console.WriteLine("enter the color of the car");
            Color = Console.ReadLine();
        }


        public void GetDistanceInKM()
        {
            Console.WriteLine("Enter speed in km/hr");
            Speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in hrs");
            hours = Convert.ToDouble(Console.ReadLine());
            double  DistanceinKM = Speed * hours;
            Console.WriteLine("Distance is{0} KM",DistanceinKM);  
        }
        public void GetSpeedInKmperhr()
        {
            Console.WriteLine("enter distance in km");
            DistanceinKM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Time in hrs");
            hours = Convert.ToDouble(Console.ReadLine());
            double GetSpeedInKmperhr = DistanceinKM / hours;
            Console.WriteLine("Speed is{0} km/hr",GetSpeedInKmperhr);
        }

        public void GetTimeInHrs()
        {
            Console.WriteLine("enter speed in km/hr");
            //this.Speed = speed;
            Speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter distance in km");
           // this.DistanceinKM = Distance;
            DistanceinKM = Convert.ToDouble(Console.ReadLine());
            double hours = DistanceinKM / Speed;
            Console.WriteLine("Time is{0} hrs",hours);
        }
    }
}
