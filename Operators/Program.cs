

//floating result
//var a = 10;
//var b = 3;

//Console.WriteLine(a / b); //output 3
//Console.WriteLine((float)a / (float)b); //output 3.33333 because its doing cast for type conversion


//operator precedence
var a = 1;
var b = 2;
var c = 3;

Console.WriteLine(a + b * c); //* and / operators have high precedence then + and -.  output 7
Console.WriteLine((a + b) * c);// if we want to change the precedence, then we can use (). output 9