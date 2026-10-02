
namespace CastTheDice
{
    public class Dice
    {
        //backingfield
        private int _currentNum;
        // property that can be accessed outside to see what the dicecast was
        public int CurrentNum => _currentNum;

        public void CastDice()
        {
            var random = new Random();
            var diceNumber = random.Next(1, 6);
            _currentNum = diceNumber;
            Console.WriteLine($"The dice landed on {_currentNum}");
        }
    }
}