
using System.Text;

var builder = new StringBuilder();

//we can also start with defauld result
//var builder = new StringBuilder("Hello world");

//append methods
//builder.Append('-', 10);
//builder.AppendLine();
//builder.Append("Header");
//builder.AppendLine();
//builder.Append('-', 10);

////Replace
//builder.Replace('-', '+');

////Remove 
//builder.Remove(0, 10);

//insert
//builder.Insert(0, new string('-', 10));

//chaining the stringBuilders
builder.Append('-', 10)
.AppendLine()
.Append("Header")
.AppendLine()
.Append('-', 10)

//Replace
.Replace('-', '+')

//Remove 
.Remove(0, 10)

//insert
.Insert(0, new string('-', 10));

Console.WriteLine(builder);
Console.WriteLine("1st char : "+builder[0]);
