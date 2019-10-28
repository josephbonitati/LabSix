using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDice();

            Console.ReadLine();
        }

        public static void RollDice()
        {
        Start:
            Console.Write("Would you like to roll the dice? (Y/N) ");
            string inputYes = "y";

            inputYes = Console.ReadLine();

            if (inputYes == "Y" || inputYes == "y")
            {
                int sides1;

                Console.Write("How many sides do you want your die to have? ");
                sides1 = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                int dice1 = rnd.Next(1, sides1);
                int dice2 = rnd.Next(1, sides1);

                Console.WriteLine("Dice 1: " + dice1);
                Console.WriteLine("Dice 2: " + dice2);
            }
            if (inputYes == "N" || inputYes == "n")
            {
                Console.WriteLine("Thanks for stopping by!");
            }
            else if (inputYes != "Y" || inputYes != "y" || inputYes != "N" || inputYes != "n")
            {
                Console.WriteLine("Please enter a Y or an N");
                goto Start;
            }
        }

    }
}
