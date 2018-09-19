using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_2108
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public float Bonus { get; set; }


        public virtual void GetSalary()
        {
        }
        public virtual void GetBonus(float bonus)
        {

        }
    }
}
