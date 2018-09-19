using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_2108
{
    class EmployeeException : Exception
    {
        public override string Message => base.Message;

        public EmployeeException(string msg, float bonus) : base(string.Format(msg, bonus))
        {

        }


    }   }

