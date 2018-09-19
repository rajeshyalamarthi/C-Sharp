using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_sep_2018.Sports;
using _08_sep_2018.sportsV1;
using _08_sep_2018.SportsV1;

namespace _08_sep_2018.Sports
{
    public class SportsV1Main
    {

        public static void Main(string[] args)
        {
            League league = new League();
            Team team1 = new Team();
            Team team2 = new Team();
          //  Team TO = new Team();
            Match M1 = new Match();
            league.GetLeagueName();

            team1.GetPlayersDetails();
            team2.GetPlayersDetails();



            Console.WriteLine("\n\nMatch is Going to Start"    );
            Console.WriteLine("**********************ALL THE BEST****************");
            //---------------Team 1

            M1.Teamscore1 = new TeamScore();
            M1.Teamscore1.DisplayScoreDetails(team1);

            M1.Teamscore2 = new TeamScore();
            M1.Teamscore2.DisplayScoreDetails(team2);


            M1.GetDisplayWinningTeam();
            M1.HighScorer();


            //M1.TeamDetails(team1);
            //M1.TeamDetails(team2);
            /********Enter Details off team 1***************/
            //M1.Teamscore1 = new TeamScore();
            //M1.Teamscore1.DisplayScoreDetails(team1);
            //M1.Teamscore2 = new TeamScore();
            //M1.Teamscore2.DisplayScoreDetails(team2);



            //M1.GetDisplayWinningTeam();
            ////M1.GetDisplayWinningTeam();

            //M1.DisplayHighScorerInTheMatch();


            ////SportsV1 sportsV1 = new _08_sep_2018.SportsV1();
            //    Match[] Matches = new Match[Permanent.Matches];
            //    Team[] Teams = new Team[Permanent.NoOfTeams];
            //    Player[] Players = new Player[Permanent.TeamSize];
            //    TeamScore[] TeamScores = new TeamScore[Permanent.NoOfTeams];
            //    PlayerScore[] PlayerScores = new PlayerScore[Permanent.TeamSize];
            //    Console.WriteLine("enter the name of the Teams\n\n");

            //    for (int TeamNo = 0; TeamNo < Permanent.Matches; TeamNo++)
            //    {
            //        Teams[TeamNo] = new Team();
            //        Console.WriteLine("enter the name of the Team{0} \n", TeamNo + 1);
            //        Teams[TeamNo].Name = Console.ReadLine();
            //        Console.WriteLine("\n");

            //        Console.WriteLine("Enter the Team number Details of respective Team {0}", Teams[TeamNo].Name);


            //        for (int PlayerNo = 0; PlayerNo < Permanent.TeamSize; PlayerNo++)
            //        {

            //            Teams[TeamNo].Players[PlayerNo] = new Player();
            //            Console.WriteLine("enter the Name of the {0}  Player of team{1}", PlayerNo + 1, Teams[TeamNo].Name);

            //            Teams[TeamNo].Players[PlayerNo].Name = Console.ReadLine();

            //            Console.WriteLine("Enter the jersy no of {0} ", Teams[TeamNo].Players[PlayerNo].Name);
            //            Teams[TeamNo].Players[PlayerNo].JersyNo = Convert.ToInt32(Console.ReadLine());



            //        }
            //    }



            ////    Console.WriteLine("Match is Started Please choose whose to bat ");

            ////string choose = Console.ReadLine().ToLower();
            ////if(choose=="h")

            ////int  Totalscore=0;
            ////matches[stno] = new Match();
            //for (int TeamCount = 0; TeamCount < Permanent.Matches; TeamCount++)
            //{
            //    Matches[TeamCount] = new Match();
            //    Matches[TeamCount].Teamscore1 = new TeamScore();
            //    Matches[TeamCount].Teamscore2 = new TeamScore();

            //    for (int PalyerCount = 0; PalyerCount < Permanent.TeamSize; PalyerCount++)
            //    {



            //        Teams[TeamCount].PlayerScores[PalyerCount] = new PlayerScore();
            //        PlayerScores[PalyerCount] = new PlayerScore();
            //        Console.WriteLine("Enter the scores of the team {0} ", Teams[TeamCount].Name);
            //        Console.WriteLine("Enter the Score of the player {0}", Teams[TeamCount].Players[PalyerCount].Name);
            //        Teams[TeamCount].PlayerScores[PalyerCount].Score = Convert.ToDouble(Console.ReadLine());

            //        Console.WriteLine("Enter the No of balls faced by player{0} ", Teams[TeamCount].Players[PalyerCount].Name);

            //        Teams[TeamCount].PlayerScores[PalyerCount].Balls = Convert.ToDouble(Console.ReadLine());


            //        //Totalscore = Totalscore + playerScores[stno].Score;
            //        //matches[teamScores].ts1.TScore = Totalscore;

            //        if (TeamCount == 0)
            //        {
            //            Matches[TeamCount].Teamscore1.TScore += Teams[TeamCount].PlayerScores[PalyerCount].Score;
            //        }
            //        else
            //        {
            //            Matches[TeamCount].Teamscore2.TScore += Teams[TeamCount].PlayerScores[PalyerCount].Score;
            //        }




            //        Teams[TeamCount].Players[PalyerCount].StrikeRate = ((Teams[TeamCount].PlayerScores[PalyerCount].Score) / (Teams[TeamCount].PlayerScores[PalyerCount].Balls)) * 100;
            //        Console.WriteLine("strikeRate of the Palyer {0}  is {1} ", Teams[TeamCount].Players[PalyerCount].Name, Teams[TeamCount].Players[PalyerCount].StrikeRate);
            //    }

            //}
            //    Console.WriteLine("the total score of first team is" + Matches[0].Teamscore1.TScore);
            //    Console.WriteLine("the total score of second team is" + Matches[1].Teamscore2.TScore);



            //for (int Teamlength = 0; Teamlength < 1; Teamlength++)
            //{
            //    TeamScores[Teamlength] = new TeamScore();

            //    if(Matches[Teamlength].Teamscore1.TScore < Matches[Teamlength+1].Teamscore2.TScore)
            //    {
            //        Console.WriteLine("Winner of the match is {0}",Teams[Teamlength+1].Name);
            //        TeamScores[Teamlength].IsWinner = true;
            //    }
            //    else
            //    {
            //        TeamScores[Teamlength + 1] = new TeamScore();
            //        Console.WriteLine("Winner of the match is {0}",Teams[Teamlength].Name);
            //        TeamScores[Teamlength + 1].IsWinner = true;
            //    }
            //}
            //    //for (int i = 0; i < team.Length; i++)
            //    //{

            //    //    matches[i] = new Match();

            //    //    if (matches[i].ts1.TScore > matches[i].ts2.TScore)
            //    //    {

            //    //        Console.WriteLine("{0} won the match vs {1}   ", team[i].TeamName, team[i].TeamName);
            //    //    }


            //    //Console.WriteLine("total score of team  is" + Totalscore);








            //}





        }
    }
}



