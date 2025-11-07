var method = ShippingMethod.Express;
Console.WriteLine(method);
Console.WriteLine(method.ToString());


//converting key to value of enum
Console.WriteLine((int)method);


//converting value to key of enum 
var methodId = 3;
Console.WriteLine((ShippingMethod)methodId);

//convert or parse a string to an enum
var methodName = "Express";

var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);

Console.WriteLine(shippingMethod);

Console.WriteLine(shippingMethod.GetType());
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3,
}



