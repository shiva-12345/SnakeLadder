using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class SnakeLadderUtility
    {

        public int diceRoll()
        {
            Random random = new Random();
            int dice = random.Next(0, 7);
            return dice;
        }
    }
}