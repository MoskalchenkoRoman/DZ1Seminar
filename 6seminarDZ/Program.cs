Console.WriteLine("Введите количество чисел для проверки:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите число:");
    int s = Convert.ToInt32(Console.ReadLine());
    array[i] = s;
}
Console.WriteLine(string.Join("|", array));
int cet = 0;
int ncet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        cet++;
    }
    else
    {
        ncet++;
    }
}
Console.WriteLine("Введено положительных чисел :" + cet);
Console.WriteLine("Введено отрицательных чисел :" + ncet);


// DZ2

//  Console.WriteLine("Введите значение b1:");
// double b1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите значение k1:");
// double k1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите значение b2:");
// double b2 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите значение k2:");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x =  (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine("Точка пересечения прямых :" + "("+ x + ":" + y + ")");
