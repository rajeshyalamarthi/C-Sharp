using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class EvenOdd : IFive, ISix
    {
        public void Five()
        {
            Console.WriteLine("This is Five");
            //throw new NotImplementedException();
        }

        public void Four()
        {
            Console.WriteLine("This is Four");
            //throw new NotImplementedException();
        }

        public void One()
        {
            Console.WriteLine("This is One");
          //  throw new NotImplementedException();
        }

        public void Six()
        {
            Console.WriteLine("This is Six");
            //throw new NotImplementedException();
        }

        public void Three()
        {
            Console.WriteLine("This Is Three");
            //throw new NotImplementedException();
        }

        public void Two()
        {
            Console.WriteLine("This Is Two");
         //   throw new NotImplementedException();
        }
    }
}
