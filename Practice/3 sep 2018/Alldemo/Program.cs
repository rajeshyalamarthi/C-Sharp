using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alldemo
{
   public class Program
    {
        // method to find sum
        public void Sum(int q, int w)
        {
            Console.WriteLine(q + w);
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("enter the value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The output value is " + (a + b));


            Program p = new Program();
            p.Sum(100, 20);

            //System.Text.ASCIIEncoding.ASCII.GetByteCount(string);


        }
    }
}

