// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

//Строки использовать нельззя



//int r = 159;
//public class MyLibrary
//{
//static public void Task27()
  //{
   // System.Console.WriteLine(MyLibrary.SumNumberIn(123));
  //}
//}
int r;
Console.Write("Введите многозначное целое число: ");
r = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(r > 0)
{
  sum  = sum + r % 10;
  r = r/10;
}
  
Console.WriteLine("Сумма чисел многозначного числа равна :" + sum );
