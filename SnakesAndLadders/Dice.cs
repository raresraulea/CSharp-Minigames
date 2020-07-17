using System;

namespace SnakesAndLadders
{
    public class Dice
    {
        static Random randomRoll = new Random();

        public static int Roll()
        {
            return randomRoll.Next(1, 7);
        }
    }
}