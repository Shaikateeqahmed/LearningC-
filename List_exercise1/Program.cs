List<string> names = new List<string>();

while (true)
{
    Console.Write("Enter a name (or press Enter to finish): ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        break;

    names.Add(input);
}

if (names.Count == 0)
{
    // Display nothing
}
else if (names.Count == 1)
{
    Console.WriteLine($"{names[0]} likes your post.");
}
else if (names.Count == 2)
{
    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
}
else
{
    int others = names.Count - 2;
    Console.WriteLine($"{names[0]}, {names[1]} and {others} others like your post.");
}