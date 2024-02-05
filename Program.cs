using System;

namespace DiceRoller
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        string playAgain = "Yes";

                        while (playAgain.ToLower() == "yes")
                        {
                        int userInputInt;
                        string userInputString; // Declare userInputString here

                                do
                                {
                                    Console.WriteLine("Enter the number of sides for a pair of dice (greater than 0)");
                                    userInputString = Console.ReadLine(); // Use userInputString to store user input
                                } while (!int.TryParse(userInputString, out userInputInt) || userInputInt < 1);
                                Console.WriteLine("Roll The Dice!");

                                int roll1 = RollDie(userInputInt);
                                int roll2 = RollDie(userInputInt);

                                int total = roll1 + roll2;

                                Console.WriteLine($"You rolled {roll1} and {roll2} for a total of {total}");

                                    switch (total)
                                    {
                                        case 2:
                                            Console.WriteLine("Snake Eyes: You rolled Two 1s");
                                            Console.WriteLine("Craps!");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ace Deuce: You rolled a 1 and 2");
                                            Console.WriteLine("Craps!");
                                            break;
                                        case 7:
                                        case 11:
                                            Console.WriteLine("Win!");
                                            break;
                                        case 12:
                                            Console.WriteLine("Box Cars: You rolled Two 6s");
                                            Console.WriteLine("Craps!");
                                            break;
                                    }

                                Console.WriteLine("Do you want to roll the dice again? Yes/No");
                                playAgain = Console.ReadLine();

                        }
            }


                static int RollDie(int numSides)
                {
                    Random randomObj = new Random();
                    return randomObj.Next(1, numSides + 1);
                }
        }
}
