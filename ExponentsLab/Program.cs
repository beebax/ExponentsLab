Console.WriteLine("Learn your integers!");
string WannaRestart;

do
{   //GET USER NUMBER
    Console.WriteLine("Enter an integer:");
    int userNum = int.Parse(Console.ReadLine());

    //IF VALID INPUT
    if(userNum > 0 && userNum <= 1290)
    {
        Console.WriteLine("Number\t\tSquared\t\tCubed");

        for (int i = 1; i <= userNum; i++)
        {
        Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");
        }
    }

    //IF INVALID INPUT
    else
    {
        Console.WriteLine("Please provide a valid input.");
    }

    //OFFER TO REPEAT
    Console.WriteLine("Press Y to repeat, any other key to end.");
    WannaRestart = Console.ReadLine();
}

while (WannaRestart == "Y");

Console.WriteLine("Thank you, goodbye.");