var a = 10;
var b = a;
b++;
Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

int[] arr = new int[3] { 1,2,3};
int[] arr2 = arr;
arr2[0] = 0;
Console.WriteLine(arr2[0]);
Console.WriteLine(arr[0]);

int number = 1;
Increment(number);
Console.WriteLine(number);//out put 1; here its take reference from stack and it will copy the value to new variable as well.

var person = new Person() { Age = 20};
MakeOld(person);
Console.WriteLine(person.Age);//output 2; here its take refrence from heap and it will copy the reference not the value to new variable, both points to one heap location.

static void Increment(int number)
{
    number += 10;
}

static void MakeOld(Person person)
{
    person.Age += 10;
}
public class Person
{
    public int Age;
}

