// DZ1

// Console.WriteLine("Введите число А");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Б");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write(numA + " в степени " + numB + " = " + NumKub(numA, numB));
// double NumKub (int numA, int numB)
// {
//     double kub = Math.Pow(numA,numB);
//     return kub;
// }


// DZ2

// Console.WriteLine("Ваше число:");
// int numA = Convert.ToInt32(Console.ReadLine());
// string num = Convert.ToString(numA);
// Console.Write(numA + " -сумма цыфр=  " + SumNum(numA));

// int SumNum (int numA)
// {
//    int sum = 0;
// while(numA != 0)
// {
//     sum += numA % 10;
//     numA /= 10;
// }
// return sum;
// }


// DZ3

// Console.WriteLine("Желаемый размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = NewArray(size);
// Console.WriteLine(string.Join("|", array));

// int [] NewArray(int size)
// {
//     int [] array1 = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array1 [i] = new Random().Next(0, 100);
//     }
//     return array1;
// }
