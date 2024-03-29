
using DiceRollWithC_.UserCommunication;

namespace DiceRollWithC_.Game
{
    class GuessingGame
    {
        private readonly Dice _dice;
        private const int IntitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled.Guess the number in {IntitialTries} tries!");

            var triesLeft = IntitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong Number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
            ? "You win!"
            : "You lose :(";

            Console.WriteLine(message);
        }
    }
}
