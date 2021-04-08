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
            int sum2 = 0;
            int game_status = 1;
            int number_of_dice = 0;
            int number_of_dice1 = 0;
            int player = 0;
            SnakeLadderUtility snakeLadder = new SnakeLadderUtility();


            Console.WriteLine("=====================================");
            Console.WriteLine("***** Welcome Snake Ladder Game *****");
            Console.WriteLine("=====================================");
            Console.WriteLine("1.Single Player Mood    2.Double Player Mood");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    player = 1;
                    Console.WriteLine("Single Player Mood Selected !");
                    break;
                case 2:
                    player = 2;
                    Console.WriteLine("Double Player Mood selected !");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Players Starting Position At: " + position);
            while (game_status == 1)
            {
                for (int i = 0; i < player; i++)
                {
                    if (player == 1 || (i == 0 && player == 2))
                    {
                        if (sum2 != 100)
                        {
                            int choice;
                            do
                            {
                                dice = snakeLadder.diceRoll();
                                Console.WriteLine("1st Player Rolled Dice And Obtained Number: " + dice);
                                Console.WriteLine("1.No Play  2.Ladder 3.Snake");
                                choice = random.Next(1, 4);
                                Console.WriteLine("1st Player Chioce: " + choice);


                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("1st Player is At Same Position: " + sum); ; ;
                                        break;
                                    case 2:
                                        Console.WriteLine("1st Player Ladder Climed At: " + sum + " New Position Became: " + (sum + dice));
                                        sum = sum + dice;

                                        break;
                                    case 3:
                                        Console.WriteLine("Snake bit 1st Player At: " + sum + " and move backward: " + dice + "And New Position" + (sum - dice));
                                        sum = sum - dice;
                                        break;

                                }

                                if (sum < 0)
                                {
                                    sum = 0;
                                    Console.WriteLine("1st Player Restart from: " + sum);

                                }
                                if (sum > 100)
                                {
                                    sum = sum - dice;
                                    Console.WriteLine("1st Player Can't move");
                                }
                            } while (choice == 2 && sum != 100);

                            number_of_dice++;
                            if (sum == 100)
                            {
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("total number of times  dice thrown : " + number_of_dice);
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("-------- congrats ! 1st Player  won -------");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");

                                game_status = 0;


                            }



                        }
                    }

                    else
                    {
                        if (sum != 100)
                        {
                            int choice;
                            do
                            {
                                dice = snakeLadder.diceRoll();
                                Console.WriteLine("2nd Player Rolled Dice And Obtained Number: " + dice);
                                Console.WriteLine("1.No Play  2.Ladder 3.Snake");
                                choice = random.Next(1, 4);
                                Console.WriteLine("2nd Player Chioce: " + choice);
                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("2nd Player is At Same Position: " + sum2);
                                        break;
                                    case 2:
                                        Console.WriteLine("2nd Ladder Climed At: " + sum2 + " New Position Became: " + (sum2 + dice));
                                        sum2 = sum2 + dice;

                                        break;
                                    case 3:
                                        Console.WriteLine("Snake bit 2nd At: " + sum2 + " and move backward: " + dice + "And New Position: " + (sum2 - dice));
                                        sum2 = sum2 - dice;
                                        break;

                                }

                                if (sum2 < 0)
                                {
                                    sum2 = 0;
                                    Console.WriteLine("2nd Player Restart from: " + sum2);

                                }
                                if (sum2 > 100)
                                {
                                    sum2 = sum2 - dice;
                                    Console.WriteLine("2nd Player Can't move");
                                }
                            } while (choice == 2 && sum2 != 100);

                            (number_of_dice1)++;
                            if (sum2 == 100)
                            {
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("total number of times  dice thrown : " + number_of_dice1);
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("-------- congrats ! 2nd Player  won -------");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++");

                                game_status = 0;


                            }
                        }



                    }
                }

            }
        }
    }
}