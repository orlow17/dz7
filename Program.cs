// TASK 1
string Sum(int start, int stop)
{
    if (start == stop) return Convert.ToString(start);
    return start + " " + Sum(start + 1, stop);
}

Console.WriteLine("Введите начальное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(n,m));