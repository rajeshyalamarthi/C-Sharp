using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
   public interface Interface1
    {
        void Message1();
       // void Message2();
    }
    public interface Interface2:Interface1
    {
        void Message2();
    }
}
