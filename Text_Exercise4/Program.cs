//Q4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

Console.WriteLine("Enter a few words separated by a space");
var input = Console.ReadLine();
var parcalCase = "";
for (int i = 0; i < input.Length; i++)
{
    if (i == 0)
    {
        parcalCase += char.ToUpper(input[i]);
    }
    else if (input[i] == ' ')
    {
        parcalCase += char.ToUpper(input[i + 1]);
        i++;
    }
    else
    {
        parcalCase += char.ToLower(input[i]);
    }
}

Console.WriteLine(parcalCase);


//Console.Write("Enter a few words separated by space: ");
//string input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Invalid Input");
//    return;
//}

//// Split input into words
//var words = input
//    .Trim()
//    .ToLower()
//    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

//string pascalCase = "";

//foreach (var word in words)
//{
//    // Capitalize first letter + remaining characters
//    pascalCase += char.ToUpper(word[0]) + word.Substring(1);
//}

//Console.WriteLine(pascalCase);
