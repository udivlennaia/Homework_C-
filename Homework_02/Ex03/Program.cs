// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 15.
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели и проверяет, яявляется ли этот день выходным.

Console.WriteLine("Введите день недели в виде числа: ");
int a = int.Parse(Console.ReadLine());
if (0 < a && a <= 5)
{
    Console.WriteLine("Это рабочий день.");
}
if ( 5 < a  && a <= 7 )
{
    Console.WriteLine("Это выходной день !");
}