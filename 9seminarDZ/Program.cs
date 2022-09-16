// DZ1

// Console.WriteLine("Введите число M:");
// int  m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N:");
// int  n = Convert.ToInt32(Console.ReadLine());
// if(m == 0 || n == 0)
// {
//    Console.WriteLine("Ошибка введения данных!"); 
// }
// while(m <= n)
// {
//     Console.Write(m + "\t");
//     m++;
// }


// DZ2

// Console.WriteLine("Введите число M:");
// int  m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N:");
// int  n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// if(m <= n)
// {
//    Console.WriteLine("Ошибка введения данных!"); 
// }
// if(m < n)
// {
//     while(m <= n)
//     {
//         Console.Write(m + "\t");
//         sum += m;
//         m++;
//     }
//     Console.WriteLine();
//     Console.WriteLine("Сумма чисел: " + sum);
// }
// else
// {
//      while(n <= m)
//     {
//         Console.Write(n + "\t");
//         sum += n;
//         n++;
//     }
//     Console.WriteLine();
//     Console.WriteLine("Сумма чисел: " + sum);
// }


// DZ3

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(A(m, n));
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m,n);            
}
Console.WriteLine();
