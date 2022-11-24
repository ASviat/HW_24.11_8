// Задача 56: Задайте двумерный массив. Напишите метод, который будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] initialMatrix = new int[4, 4];

initialMatrix = FillMatrix(initialMatrix);
PrintMatrix(initialMatrix);
int[] array1 = DevideMatrixToArrays(initialMatrix, 0);
int[] array2 = DevideMatrixToArrays(initialMatrix, 1);
int[] array3 = DevideMatrixToArrays(initialMatrix, 2);
int[] array4 = DevideMatrixToArrays(initialMatrix, 3);
TopSum(array1, array2, array3, array4);


int[,] FillMatrix(int[,] matrix)
{

    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[] DevideMatrixToArrays(int[,] matrix, int row)
{
    int[] array = new int[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j] = matrix[row, j];

    }

    return array;
}

int SumDigitsInArray(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

void TopSum(int[] arr1, int[] arr2, int[] arr3, int[] arr4)
{
    if (SumDigitsInArray(arr1) > SumDigitsInArray(arr2) && SumDigitsInArray(arr1) > SumDigitsInArray(arr3) && SumDigitsInArray(arr1) > SumDigitsInArray(arr4))
        Console.WriteLine("Наибольшая сумма в первой строке");
    if (SumDigitsInArray(arr2) > SumDigitsInArray(arr1) && SumDigitsInArray(arr2) > SumDigitsInArray(arr3) && SumDigitsInArray(arr2) > SumDigitsInArray(arr4))
        Console.WriteLine("Наибольшая сумма во второй строке");
    if (SumDigitsInArray(arr3) > SumDigitsInArray(arr2) && SumDigitsInArray(arr3) > SumDigitsInArray(arr1) && SumDigitsInArray(arr3) > SumDigitsInArray(arr4))
        Console.WriteLine("Наибольшая сумма в третьей строке");
    if (SumDigitsInArray(arr4) > SumDigitsInArray(arr2) && SumDigitsInArray(arr4) > SumDigitsInArray(arr3) && SumDigitsInArray(arr4) > SumDigitsInArray(arr1))
        Console.WriteLine("Наибольшая сумма в четвертой строке");
}

