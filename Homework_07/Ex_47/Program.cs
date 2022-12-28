// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
// 7,8 -7,1 9
 static void Main(string[] args)
{ 
    double[,] Create2DRandomArray()
    {
        Console.Write("Input numbers of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());    
 
        Console.Write("Input numbers of cols: ");
        int cols = Convert.ToInt32(Console.ReadLine()); 
         
        Console.Write("Input min possible value: ");
        int minVal = Convert.ToInt32(Console.ReadLine());   
 
        Console.Write("Input min possible value: ");
        int maxVal = Convert.ToInt32(Console.ReadLine());
 
        double[,] newArray = new double[rows,cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                 newArray[i, j] = random.Next(minVal, maxVal) + random.NextDouble();
            }
        }
                return newArray;
        }
 

    void Print2DArray(double[,] array)
    {
        for (int i = 0;i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(string.Format("{0:F1}", array[i, j]));
            }
            Console.WriteLine("");
        }
 
        Console.WriteLine("");
    }
 
    double[,] arr2D = Create2DRandomArray();
    Print2DArray(arr2D);
}
        






