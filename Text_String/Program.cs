//Trim()
var fullName = "Shaik Ateeq Ahmed    ";
Console.WriteLine("Trim : '{0}'", fullName.Trim());

//ToUpper()
Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());

// split the name base on spaces we have multiple approaches
//1 using IndexOf and Substring
//but this approach is good if u have one space in full name

var index = fullName.IndexOf(' ');
var firstName = fullName.Substring(0, index);
var lastName = fullName.Substring(index + 1);

Console.WriteLine(firstName);
Console.WriteLine(lastName);

// using split
var names = fullName.Split(' ');
Console.WriteLine("FirstName :" + names[0]);
Console.WriteLine("MiddleName :" + names[1]);
Console.WriteLine("LastName :" + names[2]);

//Replace()
Console.WriteLine(fullName.Replace("Shaik", "HI SHAIK"));
Console.WriteLine(fullName.Replace("e", "E"));
Console.WriteLine(fullName.Replace(" ", ""));

//Validation
if (String.IsNullOrEmpty(null)) Console.WriteLine("Invalid");
if (String.IsNullOrEmpty("")) Console.WriteLine("Invalid");
if (String.IsNullOrEmpty(" ")) Console.WriteLine("Invalid");
//or
if (String.IsNullOrEmpty(" ".Trim())) Console.WriteLine("Invalid");
//or
if (String.IsNullOrWhiteSpace(" ")) Console.WriteLine("Invalid");

//string to numbers
var age = "25";
Convert.ToInt32(age);
//
Convert.ToByte(age);

//number to string
float price = 19.99f;
Console.WriteLine(price.ToString("C1"));
Console.WriteLine(price.ToString("C0"));