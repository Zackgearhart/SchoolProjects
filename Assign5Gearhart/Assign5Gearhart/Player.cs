//Zack Gearhart
//3/18
//connect 4 game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5Gearhart
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string Mark { get; set; }
        public int NumberPlayed { get; set; }
        public int NumberWins { get; set; }

        public Player() { }

        public Player(string playerName)
        {
            PlayerName = playerName;
            NumberPlayed = 0;
            NumberWins = 0;

        }

        public override string ToString()
        {
            return PlayerName + " as " + Mark;
        }

    }
}
