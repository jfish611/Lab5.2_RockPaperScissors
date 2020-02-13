using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2_RockPaperScissors
{
    class HumanPlayer : Player
    {
        //private string name;
        //private Roshambo roshamboChoice;

        //public string Name { get => name; set => name = value; }
        //public Roshambo RoshamboChoice { get => roshamboChoice; set => roshamboChoice = value; }



        public HumanPlayer(string Name) : base(Name)
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine($"{Name}, Choose:\n1. Rock \n2. Paper \n3. Scissors.");
            Roshambo.TryParse(Console.ReadLine(), out Roshambo numbChoice);
            RoshamboValue = numbChoice;
            return RoshamboValue;
        }
    }
}
