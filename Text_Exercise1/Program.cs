//Q1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

Console.WriteLine("Enter a few numbers separated by a hyphen :");
var consecutiveNumbers = Console.ReadLine().Split("-").Select(int.Parse).ToArray();

var diff = consecutiveNumbers[0] - consecutiveNumbers[1];
for(int i = 1; i < consecutiveNumbers.Length-1; i++)
{
    if ((consecutiveNumbers[i] - consecutiveNumbers[i + 1]) != diff)
    {
        Console.WriteLine("Not Consecutive");
        return;
    }
}
Console.WriteLine("Consecutive");


//Console.Write("Enter numbers separated by hyphen: ");
//string input = Console.ReadLine();

//// Split and convert to numbers
//int[] numbers = input
//    .Split('-')
//    .Select(n => Convert.ToInt32(n))
//    .ToArray();

//bool isConsecutive = true;

//for (int i = 1; i < numbers.Length; i++)
//{
//    // Check forward or backward consecutive
//    if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
//    {
//        isConsecutive = false;
//        break;
//    }
//}

//Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");