// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a list of numbers separated by commas(,), we will give u 3 smallest numbers");

string input = Console.ReadLine();

var numberArray = input.Split(',').Select(s =>  int.Parse(s)).ToArray();
var numberList = new List<int>();
numberList.Add(numberArray[0]);
numberList.Add(numberArray[1]);
numberList.Add(numberArray[2]);

for (int i = 0; i < numberArray.Length; i++)
{
    if (numberArray[i] < numberList[2] && numberList[1] < numberArray[i] && numberList[0] < numberArray[i])
    {
        numberList[2] = numberArray[i];
    }else if (numberArray[i] < numberList[1] && numberList[0] < numberArray[i])
    {
        numberList[1] = numberArray[i];
    }else if(numberArray[i] < numberList[0])
    {
        numberList[0] = numberArray[i];
    }
}

for (int i = 0;i < numberList.Count; i++)
{
    Console.WriteLine(numberList[i]);
}
