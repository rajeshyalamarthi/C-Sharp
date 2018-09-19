using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_sep_2018.SportsV1;

namespace _08_sep_2018.Sports
{
  public  class TeamScore:Team
    {
        public bool Result { get; set; }
        public double TScore { get; set; }
        public bool IsWinner;
        public PlayerScore HighestScore { get; set; }
        public PlayerScore[] PlayerScores = new PlayerScore[Permanent.TeamSize];

    

            public void DisplayScoreDetails(Team team)
            {
                Console.WriteLine("\nSCORES :");
                Name = team.Name;
                Console.WriteLine("enter score details for the team: {0}", team.Name);
                double ballsRemained = Permanent.TotalNoBalls;
             
                
                HighestScore = new PlayerScore();
                for (int PlayerCount = 0; PlayerCount < PlayerScores.Length; PlayerCount++)
                {
                PlayerScores[PlayerCount] = new PlayerScore();
                PlayerScores[PlayerCount].Players = new Player();
                PlayerScores[PlayerCount].Players = team.Players[PlayerCount];
                    if (ballsRemained > 0)
                    {
                 //   Console.WriteLine("NAME OF PLAYER" + PlayerScores[PlayerCount].Players.Name);
                   // PlayerScores[PlayerCount] = new PlayerScore();
                  //  PlayerScores[PlayerCount].Players = new Player();

                       Console.WriteLine("enter the runs scored by player:{0} ",team. Players[PlayerCount].Name);
                       PlayerScores[PlayerCount].Score = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter the balls faced by the player:{0}", team.Players[PlayerCount].Name);
                        double BallsFaced = Convert.ToDouble(Console.ReadLine());
                        while (BallsFaced > ballsRemained)
                        {
                            Console.Write("Reamining Balls {0}:", ballsRemained);
                            Console.WriteLine("Enter valid no of balls");
                            BallsFaced = Convert.ToDouble(Console.ReadLine());

                        }

                       PlayerScores[PlayerCount].StrikeRate = (PlayerScores[PlayerCount].Score / BallsFaced) * 100;
                    Console.WriteLine("StrikeRate is "+PlayerScores[PlayerCount].StrikeRate);
                        ballsRemained = ballsRemained - BallsFaced;
                       PlayerScores[PlayerCount].Balls = BallsFaced;

                    }
                    else
                    {
                       PlayerScores[PlayerCount].Score = 0;
                      PlayerScores[PlayerCount].Balls = 0;
                    }

                    if (PlayerCount == 0)
                    {
                    HighestScore.Players = team.Players[PlayerCount];
                       HighestScore.Score = PlayerScores[PlayerCount].Score;
                    }
                    else
                    {
                        if (HighestScore.Score < PlayerScores[PlayerCount].Score)
                        {
                        HighestScore.Players = team.Players[PlayerCount];
                           HighestScore.Score = PlayerScores[PlayerCount].Score;
                        }
                    }



                TScore +=PlayerScores[PlayerCount].Score;

                }


                Console.WriteLine("\n----------Total score by the team {0} is :{1} ",Name, TScore);


        }
    }
}
