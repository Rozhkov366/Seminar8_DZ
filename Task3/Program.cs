/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,] Generate2DArray(int lengthRow, int lengthCol)
            {
                int [,] array = new int [lengthRow,lengthCol];
                for (int i = 0; i < lengthRow; i++)
                {
                    for (int j = 0; j < lengthCol; j++)
                    {
                        array[i,j] = new Random().Next(0,10);
                    }
                }
                return array;
            }
            void Print2dArray(int [,] array)
            {
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j <  array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            int[,] GetMultArray (int [,] array1, int [,] array2)
            {
                int [,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
                if (array1.GetLength(1) != array2.GetLength(0))
                    {
                        Console.WriteLine("Умножение невозможно, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы!");
                    }
                if (array1.GetLength(0) != array2.GetLength(1))
                    {
                        Console.WriteLine("Умножение невозможно, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы!");
                    }
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {                        
                        array3 [i,j] = 0;                    
                        for (int k = 0; k < array1.GetLength(1); k++)
                        {
                            array3 [i,j] += array1[i,k] * array2[k,j]; 
                        }                        
                    }
                }
                return array3;
                
                                        
            }

            Console.WriteLine("Первая матрица:");
            int [,] array1 = Generate2DArray(2,2);
            Print2dArray (array1);
            Console.WriteLine("Вторая матрица:");
            int [,] array2 = Generate2DArray(2,2);
            Print2dArray (array2);
            Console.WriteLine("Произведение двух матриц:");
            int [,] arrayResult = GetMultArray (array1, array2);
            Print2dArray (arrayResult);