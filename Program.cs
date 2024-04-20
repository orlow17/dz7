// TASK 1
// string Sum(int start, int stop)
// {
//     if (start == stop) return Convert.ToString(start);
//     return start + " " + Sum(start + 1, stop);
// }

// Console.WriteLine("Введите начальное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конечное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write(Sum(n,m));

// TASK 2
// int Akk(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akk(m-1, 1);
//     else return Akk(m-1, Akk(m, n-1));
// }

// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(Akk(m,n));

// TASK 3
int [] Random(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
void PrintArr(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}
void Str ( int[] arr, int i )
{
if (i >= 0)
{
    Console.Write(arr[i] + " ");
    Str(arr, i - 1); 
}
}
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
Random(arr);
PrintArr(Random(arr));
Str(arr, n - 1);