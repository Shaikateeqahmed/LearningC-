//Q3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

//Console.WriteLine("Enter 5 Unique numbers :");

//var numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

//var allUnique = new HashSet<int>(numbers).Count == numbers.Length;

//while (!allUnique)
//{
//    Console.WriteLine("Opps!, the numbers is not unique, Re-Enter the 5 Unique numbers :");

//     numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

//     allUnique = new HashSet<int>(numbers).Count == numbers.Length;
//}

//if (allUnique)
//{
//    Console.WriteLine("Miximum Numaber is : "+numbers.Max());
//}

List<int> numbers = new List<int>();

while (numbers.Count < 5)
{
    Console.Write($"Enter number #{numbers.Count + 1}: ");
    string input = Console.ReadLine();

    int num;
    if (!int.TryParse(input, out num))
    {
        Console.WriteLine("Invalid number! Try again.");
        continue;
    }

    if (numbers.Contains(num))
    {
        Console.WriteLine("Number already entered! Please enter a unique number.");
        continue;
    }

    numbers.Add(num);
}

numbers.Sort();

Console.WriteLine("Sorted unique numbers:");
foreach (var n in numbers)
{
    Console.WriteLine(n);
}