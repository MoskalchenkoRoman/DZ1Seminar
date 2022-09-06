//  DZ1

// Console.WriteLine("Желаемый размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// for(int i = 0; i < array.Length; i++)
// {
// array [i] = new Random().Next(100, 1000);
// }
// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
// if (array[i] %2==0)
// {
//     count++;
// }
// }
// Console.WriteLine(string.Join("|", array));
// Console.WriteLine(" Четных чисел - " + count);

// DZ2

// Console.WriteLine("Желаемый размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// for(int i = 0; i < array.Length; i++)
// {
// array [i] = new Random().Next(-9, 10);
// }
// int sum = 0;
// for(int i = 1; i < array.Length; i = i + 2)
// {
//     sum+= array [i];
// }
// Console.WriteLine(string.Join("|", array));
// Console.WriteLine(" Сумма чисел на нечётных позициях - " + sum);


// DZ3

// Console.WriteLine("Желаемый размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// for(int i = 0; i < array.Length; i++)
// {
// array [i] = new Random().Next(0, 100);
// }
// int min = array[0];
// int max = array[0];
// int raz = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min )
//     {
//         min = array[i];
//     }
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// raz = max - min;
// Console.WriteLine(string.Join("|", array));
// Console.WriteLine(min + " - минимальное :" + max + " - максимальное");
// Console.WriteLine("разница =" + raz);

// int value = 8;
// string binary = Convert.ToString(value, 2);
// Console.WriteLine(binary);

