//Q4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

//var list = new List<int>();

//var input = "";

//while (input != "Quit")
//{
//    Console.WriteLine("Enter a number or type 'Quit' to exit :");
//    input = Console.ReadLine();
//    int num;
//    if (!int.TryParse(input, out num) && input !="Quit")
//    {
//        Console.WriteLine("Invalid number! Try again.");
//        continue;
//    }
//    else if(input != "Quit")
//    {
//        list.Add(int.Parse(input));
//    }
//}

//list  = list.Distinct().ToList();
//Console.WriteLine("Unique Numbers are : "+String.Join(',',list));

List<int> numbers = new List<int>();

while (true)
{
    Console.Write("Enter a number or type \"Quit\" to exit: ");
    string input = Console.ReadLine();

    if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
        break;

    int number;
    if (int.TryParse(input, out number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

// Use HashSet to get unique numbers
HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

Console.WriteLine("Unique numbers entered:");
foreach (int n in uniqueNumbers)
{
    Console.WriteLine(n);
}
