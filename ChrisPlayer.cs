using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2_RockPaperScissors
{
    class ChrisPlayer : Player
    {

        public ChrisPlayer() : base("Chris")
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            Random rndom = new Random();
            int rpcChoice = rndom.Next(1, 4);
            RoshamboValue = (Roshambo)rpcChoice;
            return RoshamboValue;

        }
    }
}
