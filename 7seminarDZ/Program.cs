// DZ1

// Console.WriteLine("Введите число строк:");
// int  stringMatrix = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов:");
// int  columnMatrix = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [stringMatrix,columnMatrix];

// for (int i = 0; i < stringMatrix ; i++)
// {
//     for (int j = 0; j < columnMatrix; j++)
//     {
//         matrix[i,j] = new Random().NextDouble()*(10);
//         Console.Write($"{Math.Round(matrix[i,j], 3)}" + "\t");
           
//     }
//     Console.WriteLine();
// }



// DZ2

//  int stringMatrix = new Random().Next(1,11);
//  int columnMatrix = new Random().Next(1,11);

// double [,] matrix = new double [stringMatrix,columnMatrix];

// for (int i = 1; i < stringMatrix ; i++)
// {
//     for (int j = 1; j < columnMatrix; j++)
//     {
//         matrix[i,j] = new Random().NextDouble()*(10);
//         Console.Write($"{Math.Round(matrix[i,j])}" + "\t");
           
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите номер строки:");
// int  x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца:");
// int  y = Convert.ToInt32(Console.ReadLine());
// if (x > stringMatrix || y > columnMatrix)
// {
//     Console.WriteLine("Данная позиция отсутствует!");
// }
// if (x < stringMatrix && y < columnMatrix)
// {
//     Console.Write("В данной позиции находится : ");
//     Console.WriteLine($"{Math.Round(matrix[x,y])}");
// }


// DZ3


 int stringMatrix = new Random().Next(1,11);
 int columnMatrix = new Random().Next(1,11);

int [,] matrix = new int [stringMatrix,columnMatrix];

for (int i = 0; i < stringMatrix ; i++)
{
    for (int j = 0; j < columnMatrix; j++)
    {
        matrix[i,j] = new Random().Next(1,11);
        Console.Write($"{matrix[i,j]}" + "\t");
           
    }
    Console.WriteLine();
}

Console.WriteLine("среднеарефмитическое значение в каждом столбце");

for (int j = 0; j < columnMatrix; j++)
{
    double average =0;
    for(int i = 0; i < stringMatrix; i++ )
{
         average += matrix[i,j];
    
}
    Console.Write($"{average/stringMatrix}" + "\t");
}
