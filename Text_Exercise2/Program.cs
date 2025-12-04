//Q2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

Console.WriteLine("Enter a few numbers separated by a hyphen :");
var userInput = Console.ReadLine();

if (String.IsNullOrWhiteSpace(userInput))
{
    return;
}else
{
    var numbers = userInput.Split('-').Select(int.Parse).ToArray();
   Array.Sort(numbers);
    for (int i = 1; i < numbers.Length; i++)
    {
        if(numbers[i] == numbers[i-1]) { 
            Console.WriteLine("Duplicate");
            return;
        }
    }
}

//Console.Write("Enter numbers separated by hyphen: ");
//string input = Console.ReadLine();

//// Exit if the user pressed Enter without typing anything
//if (string.IsNullOrWhiteSpace(input))
//    return;

//// Split and convert to integers
//var numbers = input
//    .Split('-')
//    .Select(n => Convert.ToInt32(n))
//    .ToList();

//// Use a HashSet to detect duplicates
//HashSet<int> seen = new HashSet<int>();

//foreach (var num in numbers)
//{
//    if (!seen.Add(num))   // Add returns false if value already exists
//    {
//        Console.WriteLine("Duplicate");
//        return;
//    }
//}

//Console.WriteLine("No Duplicates");