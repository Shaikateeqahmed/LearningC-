//Implicit type conversion
//byte b = 1;
//int i = b;
//Console.WriteLine(i);

//Explicit type conversion
//int i = 1;
//byte b = (byte) i;
//Console.WriteLine(b);
//or
// here some of the byte's might loss because byte limit is 255
//int i = 1000;
//byte b = (byte)i;
//Console.WriteLine(b);

//non-complied type
string number = "1234";
int i = Convert.ToInt32(number);
Console.WriteLine(i);

// or 

try {
    byte b = Convert.ToByte(number);
    Console.WriteLine(b);
}
catch {
    Console.WriteLine("The number count not be converted to a byte.");
}