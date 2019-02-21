using System;

namespace coinflipapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            Console.Write("Heads or Tails, sir?");
            userGuess = Console.ReadLine();

            coin = rng.Next(0,2);

            if (coin == 0 && userGuess == "Tails")
            {
                Console.WriteLine("Winner winner chicken dinner");
            }
            else if (coin == 1 && userGuess == "Heads")
            {
                Console.WriteLine("Winner winner chicken dinner");
            }
            else
            {
                if (coin == 0 && userGuess == "heads")
                {
                    Console.WriteLine("Tails. It really be like that sometimes.");
                }
                else if (coin == 1 && userGuess == "tails")
                {
                    Console.WriteLine("Heads. It really be like that sometimes.");
                }
                else {
                    Console.WriteLine("Unable to give an answer. Chances are you made a spelling error. Press enter or return to retry.");
                }
            }
        }
    }
}
