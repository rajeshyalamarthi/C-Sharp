using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class IdentityMatrix
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix");
             int s = Convert.ToInt32(Console.ReadLine());
            int row, col;
            for (row = 0; row < s; row++)
            {
                for (col = 0; col < s; col++)
                {
                    if (row == col)
                    {
                        Console.Write(1+" ");
                    }
                    else
                        Console.Write(0+" ");
                }
                Console.WriteLine();

            }
         
            
        }
    
    }
}
