using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_sep_2018.SportsV1;

namespace _08_sep_2018.Sports
{
     public class Team
    {
         public string Name { get; set; }

      public   Player[] Players = new Player[Permanent.TeamSize];

        //public virtual void GetDisplayTeamName()
        //{
        //    Console.WriteLine("The Name Of the Team is :");
        //    Name = Console.ReadLine();

        //}
        public void GetPlayersDetails()
        {
            Console.WriteLine("\nEnter the Team Name");
            Name = Console.ReadLine();
            //Name = Console.ReadLine();
            for(int playerCount = 0; playerCount < Permanent.TeamSize; playerCount++)
            {
                Players[playerCount] = new Player();
                Console.WriteLine("enter '{0}' player name of team {1}:",playerCount+1,Name );
                Players[playerCount].Name = Console.ReadLine();
                Console.WriteLine("enter jersy no of player: {0}",Players[playerCount].Name );
                Players[playerCount].JersyNo = Convert.ToInt32(Console.ReadLine());

            }
        }
        }







       

    }

