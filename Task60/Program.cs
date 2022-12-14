// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] threeDMatrix = new int[2, 2, 2];

FillMatrix(threeDMatrix);
PrintMatrix(threeDMatrix);

void FillMatrix(int [,,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int number = random.Next(10, 100);
                if (CheckNumberExist(matrix, number) == true)
                {
                    matrix[i, j, k] = number;
                }
                else
                {
                    k--;
                }
            }
        }
    }
}

bool CheckNumberExist(int [,,] array, int random)
{
    bool result = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == random)
                result = false;
            }
        }
    }
    return result;
}


void PrintMatrix(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}{(i, j, k)}  ");
            }
            Console.WriteLine();
        } 
    }
}