using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "rajesh";
            string b = "acuvate";
            int len1 = a.Length;
            int len2 = b.Length;
            char[] array1 = new char[4];
            ///<summary>
            ///1 finding length of the strings
            ///</ summary >
            Console.WriteLine("\nthe lengths of a and b are " + len1 + ", " + len2);
            ///<summary>
            ///2 comparing the strings with each other
            ///</summary>
            Console.WriteLine(a.Equals(b));

            ///<summary>
            ///3 concationation of strings
            ///</summary>
            Console.WriteLine("\nafter concatination the string is " + string.Concat(a, b));
            ///<summary>
            ///4 to check null or empty
            ///<summary>
            Console.WriteLine("\nto check whetrher the string is empty or not " + string.IsNullOrEmpty(a));
            Console.WriteLine("\nto check whetrher the string is empty or not " + string.IsNullOrEmpty(b));

            //5 to seperate using any symbol
            Console.WriteLine("\n"+ string.Join("_", a, b));

            //6 using interned retreives value specified to that string
            Console.WriteLine("\n" + string.IsInterned(b));


            //7 using copyto string method
            a.CopyTo(3, array1, 0, 3);
            Console.WriteLine("\n" + array1.Length);
            Console.WriteLine("\n" + array1);

            //8 using copy string method
            string val1 = "hello";
            string val2 = string.Copy(val1);
            Console.WriteLine("\n" + val1);
            Console.WriteLine("\n" + val2);

            //9 using lastindexof string method
            string e = "rojocoddo";
            int z = e.LastIndexOf('o');
            Console.WriteLine("\n" + z);

            //10 using lastindexofany string method
            string d = "roajocoddodghcc";
            char[] ch = { 'z', 'z', 'r' };
            int y = d.LastIndexOfAny(ch);
            Console.WriteLine("\n" + y);

            //11 using split string method

            string f = "rajesh,yalamarthi,chowdary";
            string[] str1 = f.Split(',');
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine("\n" + str1[i]);
            }

            //12 using substring
            Console.WriteLine("\nthe sub string is " + f.Substring(2, 4));

            //13 using compare
            string k = "abcd";
            string l = "berty";
            int c = string.Compare(k, l);
            Console.WriteLine("\n" + c);

            //14 using compareordinal
            string p = "abcd";
            string h = "aerty";
            int r = string.CompareOrdinal(p, h);
            Console.WriteLine("\n" + c);

            //15 using contains
            string a1 = "ramesh";
            bool q = a1.Contains("esr");
            Console.WriteLine("\n" + q);

            //16 using ends with
            bool w = a1.EndsWith("h");
            Console.WriteLine("\n" + w);

            //17 using trim
            String b2 = " rahul  ";
            Console.WriteLine("\n{0}", b2);
            string c2 = b2.Trim();
            Console.WriteLine("\n{0}", c2);

            //18 using replace

            Console.WriteLine(b2.Replace('r', 'a'));

            //19 using clone
            Console.WriteLine("\n" + a1.Clone());

            //20 using hashcode
            string b4 = "a";
            Console.WriteLine("\n" + b4.GetHashCode());

            //21 using get type
            int b3 = 1101;
            Console.WriteLine("\n" + b3.GetType());

            //22  using indexof
            Console.WriteLine("\n" + a1.IndexOf("r"));

            //23 using tolower
            Console.WriteLine("\n" + a1.ToLower());

            //24 using toupper
            Console.WriteLine("\n" + a1.ToUpper());

            //25 using tochararray
            Console.WriteLine("\n" + a1.ToCharArray());

            //26 using reverse
            string z1 = "hello";
            char[] array2 = z1.ToCharArray();
            Array.Reverse(array2);
            Console.WriteLine("\n" + array2);
        }
    }
}
