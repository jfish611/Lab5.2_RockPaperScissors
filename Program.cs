using System;

namespace Lab5._2_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int humanWins = 0;
            int compWins = 0;
            int totalGames = 0;

            Console.WriteLine("\nWelcome to Rock Paper Scissors game. \nPlease enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine( $"\n{userName}, choose your opponent: \n1. Chris\n2. Josh ");
            string opponentChoice = Console.ReadLine();
            Player CompPlayer = null;
            HumanPlayer HumanPlayer = new HumanPlayer(userName);
            if (opponentChoice == "1")
            {
                CompPlayer = new ChrisPlayer();
            }
            else if (opponentChoice == "2")
            {
                CompPlayer = new JoshPlayer();
            }

            do
            {
                Roshambo humansChoice = HumanPlayer.GenerateRoshambo();
                Roshambo compChoice = CompPlayer.GenerateRoshambo();
                Console.WriteLine("___________________");
                Console.WriteLine($"{HumanPlayer.Name}: {humansChoice}");
                Console.WriteLine($"{CompPlayer.Name}:  {compChoice}");
                Console.WriteLine("___________________");

                Console.Write("------------------------------");


                string judgeCall;
                if ((int)humansChoice == 1 && (int)compChoice == 1)
                {
                    judgeCall = "*TIE*";
                    totalGames++;

                }
                else if ((int)humansChoice == 1 && (int)compChoice == 2)
                {
                    judgeCall = "*LOSE*";
                    compWins++;
                    totalGames++;

                }
                else if ((int)humansChoice == 1 && (int)compChoice == 3)
                {
                    judgeCall = "*WIN*";
                    humanWins++;
                    totalGames++;

                }
                else if ((int)humansChoice == 2 && (int)compChoice == 1)
                {
                    judgeCall = "*WIN*";
                    humanWins++;
                    totalGames++;


                }
                else if ((int)humansChoice == 2 && (int)compChoice == 2)
                {
                    judgeCall = "*TIE*";
                    totalGames++;

                }
                else if ((int)humansChoice == 2 && (int)compChoice == 3)
                {
                    judgeCall = "*LOSE*";
                    compWins++;
                    totalGames++;


                }
                else if ((int)humansChoice == 3 && (int)compChoice == 1)
                {
                    judgeCall = "*LOSE*";
                    compWins++;
                    totalGames++;


                }
                else if ((int)humansChoice == 3 && (int)compChoice == 2)
                {
                    judgeCall = "*WIN*";
                    humanWins++;
                    totalGames++;


                }
                else if ((int)humansChoice == 3 && (int)compChoice == 3)
                {
                    judgeCall = "*TIE*";
                    totalGames++;

                }
                else
                {
                    judgeCall = "I smell a rat";
                }
                int humanPercent = (humanWins * 100) / totalGames;
                int compPercent = (compWins * 100) / totalGames;
                int ties = totalGames - (humanWins + compWins);
                int tiePercent = (ties * 100) / totalGames;
                Console.WriteLine(judgeCall + $"\nYour winning percentage: \t{humanPercent}%\t({humanWins}/{totalGames})" +
                    $"\n{CompPlayer.Name}'s winning percentage: \t{compPercent}%\t({compWins}/{totalGames})" +
                    $"\n                     Ties:    \t{tiePercent}%\t({ties}/{totalGames})  ");

            }
            while (Console.ReadLine()=="");
        }
    }
}
