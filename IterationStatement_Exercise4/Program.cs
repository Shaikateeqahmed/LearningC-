//Q4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

for(var i=1; i<=4; i++)
{
    Console.WriteLine($"you have {5-i} chance to guess the number :");
    var guessedNumber = int.Parse( Console.ReadLine() );

    var randomNumber = new Random().Next(1,10);

    Console.WriteLine($"Random number is:{randomNumber}");
    if(guessedNumber == randomNumber)
    {
        Console.WriteLine("You Won");
        break;
    }
    else { Console.WriteLine("You Lost!"); }
}
