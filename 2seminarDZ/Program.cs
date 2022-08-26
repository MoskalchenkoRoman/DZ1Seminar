// int num = new Random().Next(100, 1000);
// int num1 = num/10;
// int num2 = num1%10;
// Console.WriteLine(num);
// Console.WriteLine(num2);

// дз 1


// Console.WriteLine("Введите число");
// string num = Console.ReadLine();
// if (num.Length <=2)
// {
//     Console.WriteLine("отсутствует третье значение");
// }
// else
// {
// Console.WriteLine(num[2]);

// }

// дз 2


Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.Write(num + "-Понедельник");
}
if (num == 2)
{
    Console.Write(num + "-Вторник");
}
if (num == 3)
{
    Console.Write(num + "-Среда");
}
if (num == 4)
{
    Console.Write(num + "-Четверг");
}
if (num == 5)
{
    Console.Write(num + "-Пятница");
}
if (num == 6)
{
    Console.Write(num + "-Суббота ВЫХОДНОЙ");
}
if (num == 7)
{
    Console.Write(num + "-Воскресенье - Гуляем))");
}
if (num < 1 || num > 7)
{
    Console.Write(num + " -не корректные данные! ");
}