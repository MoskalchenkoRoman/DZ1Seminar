// DZ_3
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= num)
{
    Console.WriteLine(i+" - в кубе = "+Math.Pow(i,3));
    i++;
}




// DZ_2
// Console.WriteLine("Введите xa");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ya");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите za");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите xb");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите yb");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите zb");
// int zb = Convert.ToInt32(Console.ReadLine());

// double ras = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));

// Console.Write("A("+xa+","+ya+","+za+")"+" "+"B("+xb+","+yb+","+zb+")"+"="+ras);


// DZ_1
// Console.WriteLine("Введите 5-значное число");
// string num = Console.ReadLine();
// if(num[0]==num[4] && num[1]==num[3])
// {
//     Console.Write(num+" -является палиндромом");
// }
// else
// {
//     Console.Write(num+" -число не палиндром");
// }