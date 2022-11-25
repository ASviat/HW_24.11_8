// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] threeDMatrix = new int[2, 2, 2];
threeDMatrix = Fill3DWithNonRepeatingDigits(threeDMatrix);


Print3DMatrix(threeDMatrix);


int IsThisDigitInMatrix(int[,,] matrix, int digit)
{

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                for (int l = 0; l < matrix.GetLength(2); l++)
                {
                    digit = random.Next(0, 11);
                    if (digit == matrix[i, j, k])
                    {
                        IsThisDigitInMatrix(matrix, digit);
                    }
                    if (digit != matrix[i, j, k])
                    {;
                        return digit;
                    }
                }
            }
        }

    }
    return IsThisDigitInMatrix(matrix, digit);
}

int[,,] Fill3DWithNonRepeatingDigits(int[,,] matrix)
{
    //Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = IsThisDigitInMatrix(matrix, matrix[i, j, k]);
            }
        }
    }
    return matrix;
}


void Print3DMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");

            }
            Console.WriteLine();
        }
    }
}

