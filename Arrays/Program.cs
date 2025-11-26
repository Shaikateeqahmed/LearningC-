var numbers = new[] { 3, 7, 9, 2, 14, 6 };

//Length 
Console.WriteLine("Length:" + numbers.Length);

//IndexOf()
Console.WriteLine(Array.IndexOf(numbers, 9));

//Clear()
Array.Clear(numbers, 0, 2);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


//Copy()
var another = new int[3];

Array.Copy(numbers, another, another.Length);

foreach(var n in another)
{
    Console.WriteLine(n);
}

//Sort();
Array.Sort(numbers);
foreach(var n in numbers) {  Console.WriteLine(n); }

//Reverse()
Array.Reverse(numbers);
foreach(var n in numbers)
{
    Console.WriteLine(n);
}