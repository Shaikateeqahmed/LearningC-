// if else
using ConditinalStatement;

var hour = 10;

if (hour > 0 && hour < 12)
    Console.WriteLine("It's morning");
else if (hour >= 12 && hour <= 18)
    Console.WriteLine("It's afternoon");
else
    Console.WriteLine("It's evening");


//conditional operator

bool isGoldCustomer = true;

//float price;
//if (isGoldCustomer)
//    price = 19.95F;
//else
//    price = 29.95F;

//Console.WriteLine(price);

float price = isGoldCustomer ? 19.95F : 29.95F;
Console.WriteLine(price);

// switchcases

var season = Season.Autumn;

//switch (season)
//{
//    case Season.Autumn:
//        Console.WriteLine("its a autumn and a beautiful season");
//        break;

//    case Season.Summer: Console.WriteLine("its perfect to go to beach");
//        break;

//    default: Console.WriteLine("I dont understand the season");
//        break;
//}

switch (season)
{
    case Season.Autumn:
    case Season.Summer:
        Console.WriteLine("You got promotion");
        break;

    default:
        Console.WriteLine("I dont understand the season");
        break;
}