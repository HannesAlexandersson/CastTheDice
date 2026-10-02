namespace CastTheDice;

public class Game
{
    // backingfields
    private int _attemptsCount = 0;
    private readonly int _attemptsLimit = 3;


    public void Run()
    {
        try
        {
            while (true)
            {
                // the main menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" =============================================");
                Console.WriteLine("||   ******CAST THE DICE******               ||");
                Console.WriteLine("||   To read the rules of the game, press '1'||");
                Console.WriteLine("||   To begin a game, press '2'              ||");
                Console.WriteLine("||   To check the leaderboards, press '3'    ||");
                Console.WriteLine("||   To exit the game, press 'X'!            ||");
                Console.WriteLine("||                                           ||");
                Console.WriteLine(" =============================================");
                Console.ForegroundColor = ConsoleColor.Green;

                var input = Console.ReadLine();

                if (input == "X" || input == "x")
                {
                    Environment.Exit(0);
                }

                if (int.TryParse(input, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            GetRules();
                            break;

                        case 2:
                            NewGame();
                            break;

                        case 3:
                            GetLeaderboards();
                            break;

                        default:
                            Console.WriteLine("Invalid input! Please try again!"); // no need to throw exeption here since they "cost" much and this can be handled within the swithc itself
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public void NewGame()
    {
        bool outOfAttempts = false;
        int attemptsLeft = _attemptsLimit;
        Dice dice1 = new();
        Dice dice2 = new();
        Console.Clear();



        while (!outOfAttempts)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Rolling the first dice..... (continue)");
            Console.ReadLine();
            dice1.CastDice();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Rolling the second dice..... (continue)");
            Console.ReadLine();
            dice2.CastDice();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now lets check if you won or lost the round... (continue)");
            Console.ReadLine();
            Console.Clear();
            // I could do something simple like: var sum = dice1 + dice2; but whats the fun in that?
            bool playerWon = DidPlayerWin(dice1.CurrentNum, dice2.CurrentNum);
            if (playerWon)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratualations!!! 🥳 You have won the game!!! The dices have rolled {dice1.CurrentNum + dice2.CurrentNum}!!");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The dices have rolled {dice1.CurrentNum + dice2.CurrentNum}... better luck next roll!!!");
                _attemptsCount++;
                attemptsLeft = _attemptsLimit - _attemptsCount; // calculate how many attempts the user has
                Console.WriteLine($"You have {attemptsLeft} attempts left... (press any key)");
                Console.ReadLine();
                Console.Clear();
                if (attemptsLeft == 0) // terminate the game with a game over message to the user
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("******GAME OVER*******");
                    Console.ReadLine();
                    outOfAttempts = true;
                }
            }


        }

    }

    public static bool DidPlayerWin(int num1, int num2)
    {
        if (num1 + num2 == 12)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static void GetRules()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Rules: (press any key to continue...)");
        Console.ReadLine(); // make sure the user reads the rules by making them manually press to continue
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("When the dices are cast the total is calculated  (press any key to continue...)");
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("If the total of the two dices amounts to 12, you have won  (press any key to continue...)");
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You have 3 attempts to cast 12  (press any key to continue...)");
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("When you're attempts are out the game will end.  (press any key to continue...)");
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("If you get 12 before your attempts run out, the game will end with you winning! (press any key to continue...)");
        Console.ResetColor();
        Console.ReadLine();
    }


    public static void GetLeaderboards()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Leaderboards are under development, please check back in the future! (press any key to continue...)");
        Console.ResetColor();
        Console.ReadLine();
    }
}
