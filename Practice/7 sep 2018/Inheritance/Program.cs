using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Moblie
    {
        string D="dial";
        string T="textmessage";

        static void Main(string[] args)
        {

            Samsung sm = new Samsung();
            Console.WriteLine("properties of samsung are " +sm.D+", "+sm.T+", "+sm.c+", "+sm.Vc);

            Apple apple = new Apple();
            Console.WriteLine("properties of apple are " + apple.D + ", " + apple.T + ", " + apple.c + ", " + apple.Vc+", "+apple.g+", "+apple.s);


            Nokia999 nk = new Nokia999();
            nk.sm = sm;
            Console.WriteLine(nk.sm.T);

        }
    }
}
