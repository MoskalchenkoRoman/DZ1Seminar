int num = new Random().Next(1, 40);
int i = 0;
Console.WriteLine(num);
while (i <= num)
{
    if (i % 2 ==0)
    Console.Write(i);
    Console.Write(" ");
    i++;
}
