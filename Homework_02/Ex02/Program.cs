// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 13. 
//Напишите программу которая, выводит третью цмфру числа или сообщает 
// что третьей цифры нет.


int a = 7;
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
int b = (int)Math.Floor(Math.Log10(a)) - 2;
int d = (int)Math.Pow(10,b);
System.Console.WriteLine(a / d % 10);
