// See https://aka.ms/new-console-template for more information


bool userKeepPlaying = true;

while (userKeepPlaying)
{
    Console.WriteLine("Enter a number");
    string userNumberInString = Console.ReadLine();
    int result = 0;
    int userNumber;
    bool isValidNumber = int.TryParse(userNumberInString, out userNumber);

    for (int i = 1; i <= userNumber; i++)
    {
        result += i;
    }

    Console.WriteLine(result);
    Console.WriteLine("Would you like to continue (y/n)?");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "n")
    {
        Console.WriteLine("Goodbye!");
        userKeepPlaying = false;
    }
}

















Console.ReadLine();