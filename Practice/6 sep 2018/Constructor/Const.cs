using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    public class vehicle1
    {
      public  string name;
         public double cost;
        public double speed;

        //public void Getdetails(string pname,double pcost,double pspeed)
        //{
        //    pname = name;
        //    pcost = cost;
        //    pspeed = speed;

        //}
        public void display(string name,double cost,double speed)
        {
            Console.WriteLine(name+" "+cost+" "+speed);
        }
    }

   public class Const
    {
        static void Main(string[] args)
        {
            vehicle1 vc = new vehicle1();
            //vc.Getdetails("pulsor", 22000, 150);
            vc.display("pulsor",22000,150);

        }
    }
}
