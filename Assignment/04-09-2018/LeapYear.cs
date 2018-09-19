using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class LeapYear
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Year to be Checked");
            double Y = Convert.ToDouble(Console.ReadLine());

            if((Y%4==0 || Y%400 ==0) &&(Y%100 != 0))
            {
                Console.WriteLine("{0} is an leap year",Y);
            }
            else
            {
                Console.WriteLine("{0} is not an leapyear",Y);
            }

        }
    }
}
