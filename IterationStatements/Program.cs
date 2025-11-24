//Even numbers

//forloop
for(var i=1; i<=10; i++)
{
    if(i%2==0 ) Console.WriteLine(i);
}

for (var i = 10; i >= 1; i--)
{
    if (i % 2 == 0) Console.WriteLine(i);
}

//forEach loop
var name = "Shaik Ateeq Ahmed";

for (var i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}
//or simple for list like string or array
foreach(var Char in name)
{
    Console.WriteLine(Char);
}


//while loops
var j = 1;
while (j <= 10)
{
    if (j % 2 == 0)
    {
            Console.WriteLine(j);
    }
    j++;
}


//Random class
Console.WriteLine("Random -----------------------------------------------");
var random = new Random();
for (var i = 0;i < 10; i++)
{
    Console.WriteLine(random.Next(1,6));
}

Console.WriteLine("Random Password -----------------------------------------------");

//Console.WriteLine((int)'a');
for (var i = 0; i < 10; i++)
{
    Console.Write((char)random.Next(97, 122));
    Console.WriteLine();
}

//or code quality
const int passwordLength =10;

var buffer = new char[passwordLength];
for (var i = 0; i < passwordLength; i++) buffer[i] = (char)('a' + random.Next(0, 26));

var passwork = new string(buffer);

Console.WriteLine(passwork);