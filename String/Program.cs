

var Fn = "Shaik";
var Mn = "Ateeq";
var Ln = "Ahmed";

var fullName = Fn + " " + Mn + " " + Ln;
var myFullName = string.Format("My full name is {0} {1} {2}", Fn, Mn, Ln);

var names = new string[3] { "Shaik", "Ateeq", "Ahmed" };
var JoinNames = string.Join(",", names);

//or 

string[] names1 = { "Shaik", "Ateeq", "Ahmed" };
var JoinNames1 = string.Join(",", names1);


Console.WriteLine(fullName);
Console.WriteLine(myFullName);
Console.WriteLine(JoinNames);
Console.WriteLine(JoinNames1);


//with out verbatim string
var text = "Hi Shaik \n Follow the below paths \n c:\\projects\\project1\\folder  \n c:\\projects\\project2\\folder";

Console.WriteLine(text);

//with verbatim string 
var text1 = @"Hi Shaik
Follow the below paths
c:\projects\project1\folder
c:\projects\project2\folder";

Console.WriteLine(text1);