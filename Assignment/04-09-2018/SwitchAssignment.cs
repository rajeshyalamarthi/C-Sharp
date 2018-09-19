using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class SwitchAssignment
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character value to be enterd");
            string c = Console.ReadLine();

            switch(c)
            {
                case "+":
                case "-":
                case "/":
                case "%":
                case "*":
                    Console.WriteLine("It is an arthimetical operator");
                    break;

                case ">":
                case "<":
                case "=":
                case ">=":
                case "<=":

                    Console.WriteLine("It is an Relational operator");
                    break;

                case "?":
                    Console.WriteLine("Its is an COnditional operator");
                    break;

                case "&&":
                case "||":
                case "!":

                    Console.WriteLine("it is an Logical operator");
                    break;

                default:
                    Console.WriteLine("it is something else");
                    break;
                
            }
                
        }
    }
}
