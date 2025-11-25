//Q5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

Console.WriteLine("Enter a series of Number separated by comma, I will say a max of the number:");

var input  = Console.ReadLine();

var numbarArray = input.Split(",").Select(n => Convert.ToInt32(n.Trim())).ToArray();

var maxNumbar = 0;

for (int i = 0; i < numbarArray.Length; i++)
{
    if (numbarArray[i] > maxNumbar)
    {
        maxNumbar = numbarArray[i];
    }

}

Console.WriteLine($"Maximum Number is : {maxNumbar}");