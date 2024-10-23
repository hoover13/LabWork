// See https://aka.ms/new-console-template for more information


// Description 1

string userAnswer = "";

do
{
    Console.WriteLine("Hello, World");
    Console.WriteLine("Would you like to continue (y/n)?");
    userAnswer = Console.ReadLine();

    if (userAnswer == "n")
    {
        Console.WriteLine("Goodbye!");
    }

}
while (userAnswer == "y");




// Description 2

string userChoice = "";

do
{
    Console.WriteLine("Enter a number:");
    string userNumberInString = Console.ReadLine();
    bool success = int.TryParse(userNumberInString, out int number);
    for (int i = number; i >= 0; i--)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();

    for (int i = 0; i <= number; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine("Would you like to continue (y/n)?");
    userChoice = Console.ReadLine();

    if (userChoice == "n")
    {
        Console.WriteLine("Goodbye!");
    }
}
while (userChoice == "y");




// Description 3

/*

bool isDoorLocked = true;

Console.WriteLine("Enter the key code.");
while (isDoorLocked)
{
    string keyInString = Console.ReadLine();
    bool success = int.TryParse(keyInString, out int key);

    if (key == 13579)
    {
        isDoorLocked = false;
        Console.WriteLine("Welcome");
    } 
}
 */





// Description 4

/*
bool isDoorLocked = true;
int numberOfAttempts = 0;

Console.WriteLine("Enter the key code.");

while (isDoorLocked && numberOfAttempts < 5)
{
    string keyInString = Console.ReadLine();
    bool success = int.TryParse(keyInString, out int key);

    if (key == 13579)
    {
        isDoorLocked = false;
        Console.WriteLine("Welcome");
    } else
    {
        numberOfAttempts += 1;

        if (numberOfAttempts == 5)
        {
            Console.WriteLine("There were too many incorrect attempts!");
        }
    }
}
*/




// Description 5

bool isDoorLocked = true;
int numberOfAttempts = 0;

Console.WriteLine("Enter the key code.");
do
{
    string keyInString = Console.ReadLine();
    bool success = int.TryParse(keyInString, out int key);

    if (key == 13579)
    {
        isDoorLocked = false;
        Console.WriteLine("Welcome");
    }
    else
    {
        numberOfAttempts += 1;

        if (numberOfAttempts == 5)
        {
            Console.WriteLine("There were too many incorrect attempts!");
        }
    }
}
while (isDoorLocked && numberOfAttempts < 5);



Console.WriteLine("End of program.");
Console.ReadLine();

