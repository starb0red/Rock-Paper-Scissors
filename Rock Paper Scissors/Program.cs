using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static string ai;
        public static int aiScore = 0;
        public static int playerScore = 0;

        static void Main(string[] args)
        {
            Game();
        }
        public static void Game()
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (aiScore == 3) { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("You Have Lost..."); Console.ReadKey(); aiScore = 0; playerScore = 0; Console.Clear(); Game(); }
            if (playerScore == 3) { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("You Have Won..."); Console.ReadKey(); aiScore = 0;  playerScore = 0; Console.Clear(); Game(); }

            RNG();
            Console.WriteLine($"Your Score: {playerScore}\nAI Score: {aiScore}");
            Console.Write("1=Rock\n2=Paper\n3=Scissors [>] ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    if (ai == "rock") { Console.WriteLine("AI picked rock. You tied."); }
                    if (ai == "paper") { Console.WriteLine("AI picked paper. You lost."); aiScore++; }
                    if (ai == "scissors") { Console.WriteLine("AI picked scissors. You won."); playerScore++; }

                    break;
                case "2":
                    if (ai == "rock") { Console.WriteLine("AI picked rock. You won."); playerScore++; }
                    if (ai == "paper") { Console.WriteLine("AI picked paper. You tied."); }
                    if (ai == "scissors") { Console.WriteLine("AI picked scissors. You lost."); aiScore++; }
                    break;
                case "3":
                    if (ai == "rock") { Console.WriteLine("AI picked rock. You lost."); aiScore++; }
                    if (ai == "paper") { Console.WriteLine("AI picked paper. You won."); playerScore++; }
                    if (ai == "scissors") { Console.WriteLine("AI picked scissors. You tied."); }
                    break;

            }
            Console.ReadKey();
            Console.Clear();
            Game();
        }
        public static void RNG()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(0, 2);

            string[] array = { "rock", "paper", "scissors" };
            ai = array[randomNumber];
        }
        public class RandomGenerator
        {
            private readonly Random _random = new Random();
            public int RandomNumber(int min, int max)
            {
                return _random.Next(min, max);
            }
        }
    }
}
