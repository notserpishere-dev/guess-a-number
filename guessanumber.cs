Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);

    while(guess != number)
    {
        Console.WriteLine("Guess a number between " + min + " and " + max + " ok?");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess == number)
        {
            guesses++;
            Console.WriteLine("Congratulations! You guessed number: " + guess);
            Console.WriteLine("It take you that much guesses: " + guesses);
        }
        else if (guess > number && guess <= max)
        {
            guesses++;
            Console.WriteLine("Number is too high");
        }
        else if (guess < number && guess >= min)
        {
            guesses++;
            Console.WriteLine("Number is too low");
        }
        else
        {
            guesses++;
            Console.WriteLine("Number is outside range!");
        }
    }
    Console.WriteLine("Are playing again? (y/n)");
    String odpowiedz = Console.ReadLine();
    switch (odpowiedz)
    {
        case "y":
            continue;
        case "n":
            Console.WriteLine("Bye bye!");
            playAgain = false;
            break;
        default:
            Console.WriteLine("y/n ONLY.");
            Console.WriteLine("Are we playing again? (y/n)");
            odpowiedz = Console.ReadLine();
            continue;
    }

}

Console.ReadKey();
