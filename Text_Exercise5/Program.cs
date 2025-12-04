//Q5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

Console.WriteLine("Enter an English word : ");
var word  = Console.ReadLine().ToLower();
var count = 0;

foreach (var alph in word)
{
    if(alph == 'a' || alph == 'e' || alph == 'i' || alph == 'o' || alph == 'u')
    {
        count++;
    }
}

Console.WriteLine("Total vowels : " + count);


//Console.Write("Enter an English word: ");
//string input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Invalid Input");
//    return;
//}

//string word = input.ToLower();
//int vowelCount = 0;

//foreach (char c in word)
//{
//    if ("aeiou".Contains(c))
//        vowelCount++;
//}

//Console.WriteLine("Number of vowels: " + vowelCount);