﻿int A = new Random().Next(1, 100);
int B = new Random().Next(1, 100);
int C = new Random().Next(1, 100);
int max = A;
if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.Write("max= ");
Console.WriteLine(max);