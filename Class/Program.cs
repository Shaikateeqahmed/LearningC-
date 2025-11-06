using Class;

var person = new Person();

person.FirstName = "Shaik";
person.LastName = "Ateeq Ahmed";
person.Introduce();

var person1 = new Person1();

person1.firstName = "Shaik";
person1.lastName = "Ateeq Ahmed";
person1.Introduce();

var cal = new Calculator();

cal.a = 1;
cal.b = 2;
Console.WriteLine(cal.add());

var cal2 = Cal.add(1, 2);
Console.WriteLine(cal2);

public class Person
{
    public string FirstName;
    public string LastName;

    public void Introduce()
    {
        Console.WriteLine("Hi, My name is " + FirstName + " " + LastName);
    }
}


