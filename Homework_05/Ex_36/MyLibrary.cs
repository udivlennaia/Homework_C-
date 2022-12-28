public  class MyLibrary
{
    //1. Метод создания массива
     
    public static int[] CreateArray(int count)
    {
        return new int[count]; 
    }


    //2. Метод, который заполняет массив.
    public static void Fill(int[]array,int min,int max)
    {
        int size = array.Length;
        for(int index = 0; index < size; index++)
        {
            array[index] = new Random().Next(min,max);
        }
    }

    //3.Метод печати массива
    public static void Print(int[]array)
    {
        int size = array.Length;
        for (int i = 0; i <size; i++)
        {
            Console.WriteLine($"{array[i],3}");
        }
        Console.WriteLine();
    }
}