﻿//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//Console.Write("Enter the dimension m of the array");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the dimension n of the array");
//int n = Convert.ToInt32(Console.ReadLine());
//int[,] randomArray = new int[m,n];

//void mas(int m, int n)
//{
//int i,j;
//Random rand = new Random();
//for (i = 0; i < m; i++)
//{
//for (j = 0; j < n; j++)
//{
//randomArray[i,j] = rand.Next(1,9);
//}
//}
//}

//void printm(int[,] array)
//{
//int i,j;
//for (i = 0; i < array.GetLength(0); i++)
//{
//Console.WriteLine();
//for (j = 0; j < array.GetLength(1); j++)
//{
//Console.Write($»{array[i,j]} «);
//}
//Console.WriteLine();
//}

//}

//mas(m,n);
//Console.WriteLine("Source array");
printm(randomArray);

// The procedure for sorting elements in a row of a two-dimensional array in descending order
//void uporyadok(int[,] array)
//{
//for (int i = 0; i < array.GetLength(0); i++)
//{
//for (int j = 0; j < array.GetLength(1); j++)
//{
//for (int k = 0; k < array.GetLength(1) — 1; k++)
//{
//if (array[i, k] < array[i, k + 1])
//{
//int temp = array[i, k + 1];
//array[i, k + 1] = array[i, k];
//array[i, k] = temp;
//}
//}
//}
//}
//}

//uporyadok(randomArray);
//Console.WriteLine("Sorted array");
//printm(randomArray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Console.WriteLine("Enter the size of the array m x n and a range of random values:");
//int m = InputNumbers("Enter m: ");
//int n = InputNumbers("Enter n: ");
//int range = InputNumbers("Enter a range: from 1 before ");

//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);

//int minSumLine = 0;
//int sumLine = SumLineElements(array, 0);
//for (int i = 1; i < array.GetLength(0); i++)
//{
  //int tempSumLine = SumLineElements(array, i);
  //if (sumLine > tempSumLine)
  //{
    //sumLine = tempSumLine;
    //minSumLine = i;
  //}
//}

//Console.WriteLine($"\n{minSumLine+1} - the row with the smallest amount ({sumLine}) elements ");


//int SumLineElements(int[,] array, int i)
//{
  //int sumLine = array[i,0];
  //for (int j = 1; j < array.GetLength(1); j++)
  //{
    //sumLine += array[i,j];
  //}
  //return sumLine;
//}

//int InputNumbers(string input)
//{
 // Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void CreateArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //array[i, j] = new Random().Next(range);
    //}
  //}
//}

//void WriteArray (int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //Console.Write(array[i,j] + " ");
    //}
    //Console.WriteLine();
  //}
//}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Console.WriteLine("Enter the dimensions of the matrices and the range of random values:");
//int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
//int n = InputNumbers("Enter the number of rows of the 1st matrix (and lines 2nd): ");
//int p = InputNumbers("Enter the number of columns of the 2nd matrix: ");
//int range = InputNumbers("Enter a range of random numbers: from 1 to ");

//int[,] firstMartrix = new int[m, n];
//CreateArray(firstMartrix);
//Console.WriteLine($"The first matrix:");
//WriteArray(firstMartrix);

//int[,] secomdMartrix = new int[n, p];
//CreateArray(secomdMartrix);
//Console.WriteLine($"The second matrix:");
//WriteArray(secondMartrix);

//int[,] resultMatrix = new int[m,p];

//MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
//Console.WriteLine($"The product of the first and second matrices:");
//WriteArray(resultMatrix);

//void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
//{
  //for (int i = 0; i < resultMatrix.GetLength(0); i++)
  //{
    //for (int j = 0; j < resultMatrix.GetLength(1); j++)
    //{
      //int sum = 0;
      //for (int k = 0; k < firstMartrix.GetLength(1); k++)
      //{
        //sum += firstMartrix[i,k] * secomdMartrix[k,j];
      //}
      //resultMatrix[i,j] = sum;
    //}
  //}
//}

//int InputNumbers(string input)
//{
  //Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void CreateArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
   // for (int j = 0; j < array.GetLength(1); j++)
    //{
     // array[i, j] = new Random().Next(range);
    //}
  //}
//}

//void WriteArray (int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //Console.Write(array[i,j] + " ");
    //}
    //Console.WriteLine();
  //}
//}

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//Console.WriteLine($"Enter the size of the array X x Y x Z: ");
//int x = InputNumbers("Enter X: ");
//int y = InputNumbers("Enter Y: ");
//int z = InputNumbers("Enter Z: ");
//Console.WriteLine($"");

//int[,,] array3D = new int[x, y, z];
//CreateArray(array3D);
//WriteArray(array3D);

//int InputNumbers(string input)
//{
  //Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void WriteArray (int[,,] array3D)
//{
  //for (int i = 0; i < array3D.GetLength(0); i++)
  //{
    //for (int j = 0; j < array3D.GetLength(1); j++)
    //{
      //Console.Write($"X({i}) Y({j}) ");
      //for (int k = 0; k < array3D.GetLength(2); k++)
      //{
        //Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      //}
      //Console.WriteLine();
    //}
    //Console.WriteLine();
  //}
//}

//void CreateArray(int[,,] array3D)
//{
  //int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  //int  number;
  //for (int i = 0; i < temp.GetLength(0); i++)
  //{
    //temp[i] = new Random().Next(10, 100);
    //number = temp[i];
    //if (i >= 1)
    //{
      //for (int j = 0; j < i; j++)
      //{
        //while (temp[i] == temp[j])
        //{
          //temp[i] = new Random().Next(10, 100);
          //j = 0;
          //number = temp[i];
        //}
          //number = temp[i];
      //}
    //}
  //}
  //int count = 0; 
  //for (int x = 0; x < array3D.GetLength(0); x++)
  //{
    //for (int y = 0; y < array3D.GetLength(1); y++)
    //{
     // for (int z = 0; z < array3D.GetLength(2); z++)
      //{
        //array3D[x, y, z] = temp[count];
        //count++;
      //}
    //}
  //}
//}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());

//int[,] nums = new int[size, size];

//int num = 1;
//int i = 0;
//int j = 0;

//while (num <= size * size)
//{
  //  nums[i, j] = num;
    //if (i <= j + 1 && i + j < size - 1)
     //   ++j;
    //else if (i < j && i + j >= size - 1)
     //   ++i;
    //else if (i >= j && i + j > size - 1)
     //   --j;
    //else
      //  --i;
    //++num;
//}

//PrintArray(nums);

//void PrintArray(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
   // {
     //   Console.Write("[ ");
       // for (int j = 0; j < array.GetLength(1); j++)
        //{
          //  Console.Write(array[i, j] + " ");
        //}
        //Console.Write("]");
        //Console.WriteLine("");
    //}
//}