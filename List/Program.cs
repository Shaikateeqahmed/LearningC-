
//var numbers = new List<int>();
//or
var numbers = new List<int>() { 1,2,3,4,5};

//Add()
numbers.Add(1);

//AddRange()
numbers.AddRange(new int[3] { 1, 5, 7 });

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//IndexOf()
Console.WriteLine("Index of 1 : "+ numbers.IndexOf(1));

//LastIndexOf();
Console.WriteLine("Last Index of 1 : " + numbers.LastIndexOf(1));

//Count
Console.WriteLine("Count :"+numbers.Count);

//Remove()
numbers.Remove(1);
foreach (var number in numbers) {  Console.WriteLine(number); }

//Remove all one's from the list
//we cant use foreach for this, it will show errors

for (int i = 0; i < numbers.Count; i++)
{

    if (numbers[i] == 1)
    {
        Console.WriteLine("is it one:"+numbers[i]);
        numbers.Remove(numbers[i]);
        i--;
    }
}

Console.WriteLine("no one's");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//Clear();
numbers.Clear();
Console.WriteLine("count of numbers array after clear: "+numbers.Count);