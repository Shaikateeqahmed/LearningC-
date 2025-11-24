
//Q2 - Write a program which takes two numbers from the console and displays the maximum of the two.


Console.WriteLine("Provide me 2 number's, I will tell the max of the two");
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = (num1 > num2) ? num1 : num2;

Console.WriteLine("The maximum number is: " + max);