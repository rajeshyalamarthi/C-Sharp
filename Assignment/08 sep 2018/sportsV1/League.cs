using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_sep_2018.sportsV1
{
  public  class League
    {
        public string NameOfTheLeague { get; set; }

        public void GetLeagueName()
        {
            Console.WriteLine("--ENTER THE NAME OF THE LEAGUE");
            NameOfTheLeague = Console.ReadLine();
            Console.WriteLine("\n***************WELCOME TO {0}-LEAGUE*************** ",NameOfTheLeague);
        }
    }
}
