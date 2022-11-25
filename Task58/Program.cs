// Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк для первой матрицы: ");
bool isParsedRowFirst = int.TryParse(Console.ReadLine(), out int rowFirst);

Console.WriteLine("Введите количество столбцов для первой матрицы: ");
bool isParsedColumnFirst = int.TryParse(Console.ReadLine(), out int columnFirst);
Console.WriteLine("Введите количество строк для второй матрицы: ");
bool isParsedRowSecond = int.TryParse(Console.ReadLine(), out int rowSecond);
Console.WriteLine("Введите количество столбцов для второй матрицы: ");
bool isParsedColumnSecond = int.TryParse(Console.ReadLine(), out int columnSecond);

if (!isParsedRowFirst || !isParsedColumnFirst || !isParsedRowSecond || !isParsedColumnSecond || columnFirst != rowSecond)
{
    Console.WriteLine("Ошибка! Введите именно числа и проверьте размерность матриц.");
}

int[,] matrixFirst = FillMatrix(rowFirst, columnFirst);
int[,] matrixSecond = FillMatrix(rowSecond, columnSecond);
PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);
Console.WriteLine();
int[,] sumProductMatrix = SumProductOfTwoMatrixes(matrixFirst, matrixSecond);
PrintMatrix(sumProductMatrix);

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

int[,] SumProductOfTwoMatrixes(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] productMatrix = new int[columnFirst, rowSecond];
    int k = 0;
    int n = 0;
    int l=0;
    int sum=default;

    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            productMatrix[n,l]= matrixOne[i, j] * matrixTwo[j, i];
          
           // productMatrix[n,l]
        }
        



    }                    //00=00*00+ 
    return productMatrix;//01=01*10+ 
                         //02=02*20+  


}                    //10=10*00+  11*10 
                     //11=10*01+  11*11