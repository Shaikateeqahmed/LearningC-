

//int[] numbers = new int[3];
//or
var numbers = new int[3];//no initialization only declaration

Console.WriteLine(numbers);

numbers[0] = 1;
//numbers[1] = 2;
//numbers[2] = 3;

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

//or
var num = new int[3] { 4, 5, 6 };

num[0] = 11;

Console.WriteLine(num[0]);
Console.WriteLine(num[1]);
Console.WriteLine(num[2]);



var boolean = new bool[3];

boolean[0] = true;

Console.WriteLine(boolean[0]);
Console.WriteLine(boolean[1]);
Console.WriteLine(boolean[2]);

var str = new string[3] { "john", "jack", "jacksen"};


Console.WriteLine(str[0]);
Console.WriteLine(str[1]);
Console.WriteLine(str[2]);

//or

string[] str1 = { "john1", "jack1", "jacksen1" };


Console.WriteLine(str1[0]);
Console.WriteLine(str1[1]);
Console.WriteLine(str1[2]);