public class MyLibrary
{
    //Создание массива
    public static int[]CreateArray(int count)
    {
    return new int[count];
    }



//Заполнение массива числами
public static void Fill(int[]array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,15);
    }
}
 
   
 
//Печать массива
public static string Print(int[]array)
{
    return String.Join ("",array);
}


// Возведение в степень
 public static int Pow(int a, int b)
{
    int result = 1;
    for(int i = 0; i<b; i++)
    {
        result*=a;
    }
    return result;
}

//Написать конвертор из 15-й в 10-ю сиситему счисления.
 public static int ToDec(int[]value)
{
    int result = 0;
    int count = value.Length;
    for(int i = 0;i<count; i++)
    {
        result+= value[i]* Pow(15,count-1-i);
    }
    return result;
}
}