//Q2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

Console.WriteLine("Enter Your Name: ");
var userName = Console.ReadLine().ToCharArray();

Array.Reverse(userName);

var reverseNameStr = new string(userName);

Console.WriteLine(reverseNameStr);

