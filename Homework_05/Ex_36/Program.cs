// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] CreateArray(int count)
//{
//     return new int[count]; 
//}

// void Fill(int[]array,int min,int max)
//{
//    int size = array.Length;
//    for(int index = 0; index < size; index++)
//    {
//         array[index] = new Random().Next(100,999);
//    }
//}

//int[]Counter(int[]array,int min, int max)
//{
//    int result = 0;
//    int size = array.Length;
//    for( i = 0;i> 0; i++)
//    result++;
//    return result;
//}

//int []sum =  CreateArray( count);
//FillArray(sum,100,999);
//int[]Counter(sum,100,999);
//Console.WriteLine(sum);
//Console.WriteLine();




short[]numbers = new short[2];
int summa = 0;
Random random = new Random();
for(short i=0; i<numbers.Length;i++ )
{
    numbers[i]= Convert.ToInt16(random.Next(100,999));
    Console.WriteLine("Element:"+numbers[i]);
    
     summa += numbers[i];
} 

Console.WriteLine("Сумма полижительных чисел="+summa);







