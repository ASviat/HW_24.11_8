// Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк для первой матрицы: ");
// bool isParsedRowFirst = int.TryParse(Console.ReadLine(), out int rowFirst);

// Console.WriteLine("Введите количество столбцов для первой матрицы: ");
// bool isParsedColumnFirst = int.TryParse(Console.ReadLine(), out int columnFirst);
// Console.WriteLine("Введите количество строк для второй матрицы: ");
// bool isParsedRowSecond = int.TryParse(Console.ReadLine(), out int rowSecond);
// Console.WriteLine("Введите количество столбцов для второй матрицы: ");
// bool isParsedColumnSecond = int.TryParse(Console.ReadLine(), out int columnSecond);

// if (!isParsedRowFirst || !isParsedColumnFirst || !isParsedRowSecond || !isParsedColumnSecond || columnFirst != rowSecond)
// {
//     Console.WriteLine("Ошибка! Введите именно числа и проверьте размерность матриц.");
// }

//int[,] matrixFirst = new int [2,2];
int[,] matrixFirst = { { 1, 2 }, { 3, 4 } };
int[,] matrixSecond = { { 5, 6 }, { 7, 8 } };
PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);
Console.WriteLine();
int[] array1Rows = DevideMatrixIntoArrayWithRows(matrixFirst, 0);
int[] array1Columns=DevideMatrixIntoArrayWithColumns(matrixFirst,1);
int[] array2Rows=DevideMatrixIntoArrayWithRows(matrixSecond,0);
int[] array2Columns = DevideMatrixIntoArrayWithColumns(matrixSecond, 1);
PrintArray(array1Rows);
PrintArray(array2Columns);
int[,]resultMatrix=MakeProductofMatrixesFromArrays(array1Rows,array2Columns);
Console.WriteLine();
PrintMatrix(resultMatrix);

// int[,] FillMatrix(int line, int column)
// {
//     int[,] matrix = new int[line, column];
//     Random random = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(0, 11);
//         }
//     }
//     return matrix;
// }

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

int[] DevideMatrixIntoArrayWithRows(int[,] matrix, int row)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = matrix[row, i];
    }
    return array;
}
int[] DevideMatrixIntoArrayWithColumns(int[,] matrix, int column)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[i] = matrix[i, column];
    }
    return array;
}



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,] MakeProductofMatrixesFromArrays(int[] array1, int[] array2, int row)
{
    int[,] prodMatr = new int[array1.Length, array2.Length];
    int sum=default;
    for (int i = 0; i < prodMatr.GetLength(0); i++)
    {
        for (int j = 0; j < prodMatr.GetLength(1); j++)
        {
            sum += array1[j] * array2[j];
            prodMatr[i, j]=sum;
        }
        
    }
    return prodMatr;
}
