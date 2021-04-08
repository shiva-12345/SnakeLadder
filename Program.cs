using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int position = 0;
            int dice;
            int sum = 0;
            int game_status = 1;


            SnakeLadderUtility snakeLadder = new SnakeLadderUtility();
            Console.WriteLine("=====================================");
            Console.WriteLine("***** Welcome Snake Ladder Game *****");
            Console.WriteLine("=====================================");
            Console.WriteLine("-----------For Single Player Mode------------");
            Console.WriteLine("Player Starting Position At: " + position);
            while (game_status == 1)
            {
                dice = snakeLadder.diceRoll();
                Console.WriteLine("Player Rolled Dice And Obtained Number: " + dice);
                Console.WriteLine("1.No Play  2.Ladder 3.Snake");
                int choice = random.Next(1, 4);
                Console.WriteLine("Player Chioce: " + choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Player is At Same Position: " + sum); ; ;
                        break;
                    case 2:
                        Console.WriteLine("Ladder Climed At: " + sum + " New Position Became" + (sum + dice));
                        sum = sum + dice;

                        break;
                    case 3:
                        Console.WriteLine("Snake bit At: " + sum + " and move backward: " + dice);
                        sum = sum - dice;
                        break;

                }
                if (0 > sum)
                {
                    sum = 0;
                    Console.WriteLine("Player Restart From: " + sum);
                }
                if (sum == 100)
                {
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("-------- congrats ! you won -------");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++");

                    game_status = 0;

                }
            }

        }
    }
}