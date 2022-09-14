// DZ1
// int colCount = 6;
// int rowCount = 5;
// int[,] arr = GenerateArray(rowCount, colCount);

// Console.WriteLine("Исходный массив");
// PrintArray(arr);

// Console.WriteLine("Сортировка по строкам: ");
// int[] row = new int[colCount];
// for (int i = 0; i < rowCount; i++)
// {
//     for (int j = 0; j < colCount; j++)
//         row[j] = arr[i, j];
//         BubbleSort(row);
//         Insert(true, i, row, arr);
// }
// PrintArray(arr);

// Console.WriteLine("Сортировка по столбцам: ");
// int[] col = new int[rowCount];
// for (int i = 0; i < colCount; i++)
// {
//     for (int j = 0; j < rowCount; j++)
//         col[j] = arr[j, i];
//         BubbleSort(col);
//         Insert(false, i, col, arr);
// }
// PrintArray(arr);
        

// void Insert(bool isRow, int dim, int[] source, int[,] dest)
// {
//     for (int k = 0; k < source.Length; k++)
//     {
//         if (isRow)
//             dest[dim, k] = source[k];
//         else
//             dest[k, dim] = source[k];
//     }
// }
// int[,] GenerateArray(int t, int i)
// {
// int[,] table = new int[t, i];
// Random random = new Random();
// for (int a = 0; a < t; a++)
// {
//     for (int b = 0; b < i; b++)
//     {
//         table[a, b] = random.Next(0, 11);
//     }
// }
// return table;
// }
// void PrintArray(int[,] array)
// {
// for (int a = 0; a < array.GetLength(0); a++)
// {
//     for (int b = 0; b < array.GetLength(1); b++)
//     {
//         Console.Write(array[a, b] + "\t");
//     }
//     Console.WriteLine();
// }
// }
// void BubbleSort(int[] inArray)
// {
// for (int i = 0; i < inArray.Length; i++)
//     for (int j = 0; j < inArray.Length - i - 1; j++)
//     {
//         if (inArray[j] < inArray[j + 1])
//         {
//             int temp = inArray[j];
//             inArray[j] = inArray[j + 1];
//             inArray[j + 1] = temp;
//         }
//     }
// }

// DZ2

// int colCount = 6;
// int rowCount = 5;
// int[,] arr = GenerateArray(rowCount, colCount);
// PrintArray(arr);
// Console.WriteLine("Сумма элементов строки");
// int [] sumArr = new int [rowCount];
// for (int i=0;i<rowCount;i++)
// {
//     for(int j=0;j<colCount;j++)
//     {
//             sumArr[i]+=arr[i,j];
//     }        
// } 
// Console.WriteLine(string.Join("\t", sumArr));   
// int minValue = sumArr[0];
// int minValuei = 1;
// for (int i = 0; i < rowCount; i++)
// {
//     if(sumArr[i] < minValue)
//     {
//         minValue = sumArr[i];
//         minValuei = i+1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Минимальное значение - " + minValue + "  Находится в строке - " + minValuei);
// Console.WriteLine();


// DZ3

// int colCount = 2;
// int rowCount = 2;
// int[,] arrA = GenerateArray(rowCount, colCount);
// PrintArray(arrA);
// Console.WriteLine();
// int[,] arrB = GenerateArray(rowCount, colCount);
// PrintArray(arrB);
// Console.WriteLine();
// int[,] arrC = new int [rowCount,colCount];
// for (int i = 0; i < arrC.GetLength(0); i++)
// {
//     for (int j = 0; j < arrC.GetLength(1); j++)
//     {
//         for (int k = 0; k < colCount; k++)
//         {
//             arrC[i,j] += arrA[i,k] * arrB[k,j];
//         }
//         Console.Write(arrC[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// DZ4


// int [,,] matrix = 
// {
//     {
//         {25,35},
//         {50,84}
//     },
//     {
//         {50,66},
//         {77,23}
//     },
// };
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix.GetLength(2); k++)
//       {
//         Console.Write(matrix[i,j,k] + "(" +i+j+k+ ")" + "\t");
//       } 
//       Console.WriteLine(); 
//     }
// }


// DZ5

int m = 4;
int n = 4;
int s = 1;
 int[,] array = new int[m,n];
 
for (int y = 0; y < n; y++)
{
    array[0,y] = s;
    s++;
}
for (int x = 1; x < m; x++) 
{
    array[x,n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--) 
{
    array[m - 1,y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--) 
{
    array[x,0] = s;
    s++;
}

int c = 1;
int d = 1;
 
while (s < m * n) 
{

    while (array[c,d + 1] == 0) 
    {
        array[c,d] = s;
        s++;
        d++;
    }
 

    while (array[c + 1,d] == 0) 
    {
        array[c,d] = s;
        s++;
        c++;
    }
 
    while (array[c,d - 1] == 0) 
    {
        array[c,d] = s;
        s++;
        d--;
    }
 
    while (array[c - 1,d] == 0) 
    {
        array[c,d] = s;
        s++;
        c--;
    }
}
 
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x,y] == 0) 
        {
            array[x,y] = s;
        }
    }
}

for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x,y] < 100) 
        {
            Console.Write(array[x,y] + "\t");
        } 
        else 
        {
            Console.Write(array[x,y] + "\t");
        }
    }
    Console.WriteLine();
}
    





// Треугольник

// int row = 10;
// int[,] triangle = new int [row, row];
// const int cellWidth = 3;

// void FillTriangle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         triangle[i, 0] = 1;
//         triangle[i, i] = 1;
//     }
//     for (int i = 2; i < row; i++)
//     {
//         for (int j = 1; j <=i; j++)
//         {
//             triangle[i, j] = triangle[i-1, j-1]+triangle[i-1, j];
//         }
//     }
// }

// void PrintTriangle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             if (triangle[i, j]!=0)
//             {
//                 Console.Write($"{triangle[i, j],cellWidth}");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void Madgik()
// {
//     int col = cellWidth*row;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j <=i; j++)
//         {
//             Console.SetCursorPosition(col, i + 1);
//             if(triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
//             col+= cellWidth *2;
//         }
//         col = cellWidth*row - cellWidth* (i+1);
//         Console.WriteLine();
//     }
// }

// Console.ReadLine();
// FillTriangle();
// Madgik();
// PrintTriangle();
// Console.ReadLine();
