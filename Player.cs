using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2_RockPaperScissors
{
    public abstract class Player
    {      //FIELDS
        private string name;
        private Roshambo roshamboValue;
     
            //PROPERTIES
        public string Name { get => name; set => name = value; }
        public Roshambo RoshamboValue { get => roshamboValue; set => roshamboValue = value; }
            //CONSTRUCTORS
        public Player(string name)
        {
            this.Name = name;
        }

        public Player()
        {

        }

        //METHODS
        public abstract Roshambo GenerateRoshambo();

    }
}
