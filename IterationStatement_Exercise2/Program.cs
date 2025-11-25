
//Q2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

int sum = 0;

while (true)
{
    Console.Write("Enter a number or \"ok\" to exit: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "ok")
        break;

    int number;

    if (int.TryParse(input, out number))
    {
        sum += number;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

Console.WriteLine("Total Sum = " + sum);