
//Q3 - Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

Console.Write("Enter image width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter image height: ");
int height = Convert.ToInt32(Console.ReadLine());

if (width > height)
{
    Console.WriteLine("The image is Landscape.");
}
else if (height > width)
{
    Console.WriteLine("The image is Portrait.");
}
else
{
    Console.WriteLine("The image is Square.");
}