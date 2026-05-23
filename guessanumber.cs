Random random = new Random();
bool playAgain = false; 
int guess;
int number;
int guesses;
int min = 1;
int max = 100;

void menu()
{
    // ik I could do that in one WriteLine by using \n but I like this more
    Console.WriteLine("Guess the number by notserpishere!");
    Console.WriteLine("Current Settings: Min: " + min + ", Max: " + max);
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Start new game");
    Console.WriteLine("2. Settings (change numbers min and max)");
    Console.WriteLine("3. Exit");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        playAgain = true;
    }
    else if (input == 2)
    {
        Console.Write("Set min number (current: " + min + ") ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Set max number (current: " + max + ") ");
        max = Convert.ToInt32(Console.ReadLine());
        menu();
    }
    else if (input == 3)
    {
        Console.Write("Bye!");
        playAgain = false;
    }
    else
    {
        Console.Write("Invalid option");
        menu();
    }
}
menu();

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1); // idk C# is weird here that I need to add 1

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
    String answer = Console.ReadLine();
    switch (answer)
    {
        case "y":
            continue;
        case "n":
            menu();
            playAgain = false;
            break;
        default:
            Console.WriteLine("y/n ONLY.");
            Console.WriteLine("Are we playing again? (y/n)");
            answer = Console.ReadLine();
            continue;
    }

}
Console.ReadKey();
