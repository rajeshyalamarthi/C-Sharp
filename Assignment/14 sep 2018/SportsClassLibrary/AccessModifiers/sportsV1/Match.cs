using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_sep_2018.SportsV1
{
    public class Match
    {
        public PlayerScore ManoftheMatch { get; set; }
        public PlayerScore HighScore { get; set; }

        public TeamScore Teamscore1 { get; set; }
        public TeamScore Teamscore2 { get; set; }

        public void HighScorer()
        {
            HighScore = new PlayerScore();
            if (Teamscore1.HighestScore.Score > Teamscore2.HighestScore.Score)
            {
                HighScore = Teamscore1.HighestScore;
            }

            else
            {
                HighScore = Teamscore2.HighestScore;
            }

            Console.WriteLine("*****Highest Scorer In the Match is:{0}", HighScore.Players.Name);
        }

        public void GetDisplayWinningTeam()
        {
            Teamscore1.IsWinner = false;
            Teamscore2.IsWinner = false;

            if (Teamscore1.TScore > Teamscore2.TScore)
            {
                Teamscore1.IsWinner = true;

                Console.WriteLine("\n-----team:{0}  won the match-********CONGRAGULATIONS************", Teamscore1.Name);
                ManoftheMatch = Teamscore1.HighestScore;

                Console.WriteLine("\n\t*****{0}:TeamScoreCard", Teamscore1.Name);
                Console.WriteLine("PlayerName".PadRight(22)+"Runs".PadRight(22)+"Ballsfaced".PadRight(22)+"Strikerate".PadRight(22));
                for (int PlayerNo = 0; PlayerNo < Permanent.TeamSize; PlayerNo++) {
                    Console.WriteLine("{0}".PadRight(22)+"{1}".PadRight(22)+"{2}".PadRight(22)+"{3}".PadRight(22),Teamscore1.PlayerScores[PlayerNo].Players.Name,Teamscore1.PlayerScores[PlayerNo].Score,Teamscore1.PlayerScores[PlayerNo].Balls,Teamscore1.PlayerScores[PlayerNo].StrikeRate);


                } }
            else
            {
                Teamscore2.IsWinner = true;
                Console.WriteLine("{0} -team won the match", Teamscore2.Name);
                ManoftheMatch = Teamscore2.HighestScore;
                Console.WriteLine("\n\t*****{0}:TeamScoreCard", Teamscore2.Name);
                Console.WriteLine("PlayerName".PadRight(22)+"Runs".PadRight(22)+"Ballsfaced".PadRight(22)+"Strikerate".PadRight(22));
                for (int PlayerNo = 0; PlayerNo < Permanent.TeamSize; PlayerNo++)
                {
                    Console.WriteLine("{0} ".PadRight(22)+"{1}".PadRight(22)+"{2}".PadRight(22)+"{3}".PadRight(22),Teamscore2.PlayerScores[PlayerNo].Players.Name,Teamscore2.PlayerScores[PlayerNo].Score,Teamscore2.PlayerScores[PlayerNo].Balls,Teamscore2.PlayerScores[PlayerNo].StrikeRate);


                }
            }

            Console.WriteLine("\n***** Man of the match is {0}", ManoftheMatch.Players.Name);
        }
    }
}
