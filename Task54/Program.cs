// Задача 54: Задайте двумерный массив. Напишите метод, который упорядочит 
// по убыванию элементы каждой строки двумерного массива. И продемонстрируйте его работу.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк: ");
bool isParsedLines = int.TryParse(Console.ReadLine(), out int lines);
Console.WriteLine("Введите количество столбцов: ");
bool isParsedColumns = int.TryParse(Console.ReadLine(), out int columns);

if (!isParsedLines || !isParsedColumns)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] filledMatrix = FillMatrix(lines, columns);
PrintMatrix(filledMatrix);
Console.WriteLine();
int[,] devidedMatrix = DevideIntoSortedArrayByRows(filledMatrix);
PrintMatrix(devidedMatrix);

int[,] FillMatrix(int line, int column)
{
    int[,] matrix = new int[line, column];
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

int[,] DevideIntoSortedArrayByRows(int[,] matrix)
{

    int temp = default;
    int[] array = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++) // по рядам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // строка
        {
            for (int n = 1; n < matrix.GetLength(1); n++) //добавочный прогон по строке
            {
                if (matrix[i, n - 1] <= matrix[i, n])
                {
                    temp = matrix[i, n - 1];
                    matrix[i, n - 1] = matrix[i, n];
                    matrix[i, n] = temp;
                }
            }
        }
    }
    return matrix;
}