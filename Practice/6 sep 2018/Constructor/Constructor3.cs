using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Constructor3
    {// with the help of this in the constructor we can intialize the values for parameters of other constructor
        //public Constructor3():this(11,"parleg")
        //{

        //}   
        //public Constructor3(int size,string name)
        //{
        //    Console.WriteLine("size is {0} and name is {1}",size,name);
        //}

        public Constructor3(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("error", "a");
            }

        }

    }

}
