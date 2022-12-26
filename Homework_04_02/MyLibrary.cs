
public class MyLibrari
{
public static  int SumNumberIn(int value)
{
// Подсчет суммы чисел многозначного числа

    int r = 0;
    while (value != 0)
    {
        r += value % 10;
        value /= 10;
    }
    return r;
}
}