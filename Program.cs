// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Y = 90;
int Z = Y + 90000;
Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
int? Sum(int? x,int? y )
{

return x + y; 
}