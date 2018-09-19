using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizeofdatatypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string x = "acuvate";

            Console.WriteLine("size of string given is "+System.Text.ASCIIEncoding.Unicode.GetByteCount(x));

            //// to find the size of datatype
            Console.WriteLine("Size of float is "    + sizeof(float) + ",   min value of float is " + float.MinValue + " ,  max value of float is " + float.MaxValue);
            Console.WriteLine("Size of double is "   + sizeof(double) + ",  min value of double is " +double.MinValue + " ,  max value of double is " + double.MaxValue);
            Console.WriteLine("Size of int is "      + sizeof(int) + ",     min value of int is " + int.MinValue + " ,       max value of int is " + int.MaxValue);
            Console.WriteLine("Size of long is "     + sizeof(long) + ",    min value of long is " + long.MinValue + " ,     max value of long is " + long.MaxValue);
            Console.WriteLine("Size of byte is "     + sizeof(byte) + ",    min value of byte is " + byte.MinValue + " ,     max value of byte is " + byte.MaxValue);
            Console.WriteLine("Size of char is "     + sizeof(char) + ",    min value of char is " + char.MinValue + " ,     max value of char is " + char.MaxValue);
            Console.WriteLine("Size of short is "    + sizeof(short) + ",   min value of short is " + short.MinValue + " ,   max value of short is " + short.MaxValue);
            //Console.WriteLine("Size of bool is " + sizeof(bool));
        }
    }
}
