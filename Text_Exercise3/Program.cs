//Q3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

using System.Globalization;

Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00) :");
var Input = Console.ReadLine();

if (String.IsNullOrWhiteSpace(Input))
{
    Console.WriteLine("Invalid Time");
    return;
}

var timeArray = Input.Split(':').Select(int.Parse).ToArray();

if (timeArray[0] >= 0 && timeArray[0] <= 23 && timeArray[1]>=0 && timeArray[1]<=59)
{
    Console.WriteLine("Ok");
}
else
{
    Console.WriteLine("Invalid Time");
}


//Console.Write("Enter a time in 24-hour format (e.g. 19:00): ");
//string input = Console.ReadLine();

//// If user enters nothing → invalid
//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Invalid Time");
//    return;
//}

//// Try parsing using exact 24-hour format
//DateTime time;
//bool isValid = DateTime.TryParseExact(
//    input,
//    "HH:mm",
//    CultureInfo.InvariantCulture,
//    DateTimeStyles.None,
//    out time
//);

//if (isValid)
//    Console.WriteLine("Ok");
//else
//    Console.WriteLine("Invalid Time");