
var dateTime = new DateTime(2015, 1, 1);
var now = DateTime.Now;
var today = DateTime.Today;

Console.WriteLine(dateTime);
Console.WriteLine("Hour :" +now.Hour);
Console.WriteLine("Minute : "+now.Minute);

//-----------------------------------------------------------------------------------

var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(tomorrow);
Console.WriteLine(yesterday);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString());

//format Specifier
Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));


