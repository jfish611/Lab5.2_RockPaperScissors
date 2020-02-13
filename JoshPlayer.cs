using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2_RockPaperScissors
{

    class JoshPlayer : Player
    {
        public JoshPlayer(): base("Josh")
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            int rpcChoice = 1;
            RoshamboValue = (Roshambo)rpcChoice;
            return RoshamboValue;
        }
        
    }
}


