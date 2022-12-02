// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 4.
// Найти максимальное из трех чисел. Не получилась

Console.WriteLine("start"); // начало
int a = 44; // определили первое число
int b = 5; // определили второе число
int c = 78; // определили третье число
int max = a; // определили максимальным первое число
if(b > max) //условие -  если второе число боьше максимального
{
    max = b; // второе число становится максимальным
}
else if (max = a) // иначе первое число остается максимальным 
if(c > max) // условие - если третье число больше максимального
{
    max = c; // максимальным становится третье число
}
else if(max = a) // иначе первое число остается максимальньм
Console.WriteLine(max); // вывод максимального числа

Console.WriteLine("end"); // окончание




int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
   Console.WriteLine("{0} is big", a);
else if (b>a && b>c)
   Console.WriteLine("{0} is big", c);
Console.ReadLine();