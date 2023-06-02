
string name = GetName();
var date = DateTime.UtcNow;

MainMenu(name);
void MainMenu(string name)
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine($"Hello {name}. The current date and time is: {date} UTC. This is a math game.");
    Console.WriteLine(@$"What game would you like to play?
[A]ddition
[S]ubtraction
[M]ultiplication
[D]ivision
[Q]uit Game");
    Console.WriteLine("-------------------------------------");

    string gameSelection = Console.ReadLine().ToUpper().Trim();

    switch (gameSelection)
    {
        case "A":
            AdditionGame("Hey");
            break;
        case "S":
            SubtractionGame();
            break;
        case "M":
            MultiplicationGame();
            break;
        case "D":
            DivisionGame();
            break;
        case "Q":
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(1);
            break;

    }
}

string GetName()
{
    Console.WriteLine("Please enter your name: ");
    var name = Console.ReadLine();
    return name;
}

void AdditionGame(string a)
{
    Console.WriteLine(a);
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int userScore = 0;

    for(int i=0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            userScore++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        if(i == 4)
        {
            Console.WriteLine($"Game over. Your score is {userScore}");
        }
    }
}

void SubtractionGame()
{
    Console.WriteLine();
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int userScore = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct!");
            userScore++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {userScore}");
        }
    }
}

void MultiplicationGame()
{
    Console.WriteLine();
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int userScore = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct!");
            userScore++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {userScore}");
        }
    }
}
void DivisionGame()
{
    Console.WriteLine();
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int remainder;
    int userScore = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == Math.DivRem(firstNumber, secondNumber, out remainder))
        {
            Console.WriteLine("Correct!");
            userScore++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your score is {userScore}");
        }
    }

}