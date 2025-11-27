//Q5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

var list  = new List<int>();

while (list.Count < 5) {
    Console.WriteLine("Enter a list of comma separated 5 Numbers : ");
    var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
    if(input.Length < 5)
    {
        Console.WriteLine("Invalid List");
        continue;
    }
    foreach (int i in input) { 
    list.Add(i);
    }
}

list.Sort();

for(var i=0; i<3; i++)
{
    Console.WriteLine(list[i]);
}