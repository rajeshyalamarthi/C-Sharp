using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class TypeConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value which is to be converted");
            var a = Console.ReadLine();
            Console.WriteLine("Enter to which datatype it to be converted like int/string/double/char/object/long....");
            string str = Console.ReadLine();
            
                switch (str)
            {

                case "long":
                    long k = 0;
                    bool z = long.TryParse(a, out k);
                    if (z)
                    {
                        Console.WriteLine("converted:"+(int) k );
                    }
                    else
                        Console.WriteLine("not converted");
                    break;




                case "char":

                    int h = Convert.ToInt32(a);
                    char ch = Convert.ToChar(h);
                    Console.WriteLine(ch);
                    //int val = (int)'8';
                    //char d ;
                    /////int val = (int)Char.GetNumericValue('8');
                    //Console.WriteLine(val);

                    //bool y = char.TryParse(a, out d);
                    //if (y)
                    //{
                    //    Console.WriteLine("converted :"+ (int) d);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("not converted");
                    //}
                    
                   
                    break;

                case "int":
                    float c = 0;
                    bool x = float.TryParse(a,out c);
                    if (x)
                    {
                        Console.WriteLine("Converted :"+(int)c);
                    }
                    else
                    {
                        Console.WriteLine("not COnverted");
                    }
                   
                    break;


                default:
                    Console.WriteLine("enter valid one");
                    break;

                //case "double":
                //    int w = double(a);
                //    Console.WriteLine();
                //    break;
                    
            }



        }
    }
}
