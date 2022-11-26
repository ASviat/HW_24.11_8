
int[,,] threeDMatrix = new int[2, 2, 2];
FillMatrix(threeDMatrix);
PrintMatrix(threeDMatrix);

int Recursion(int[,,] array,int digit, int i = 0, int j = 0, int k = 0)
{
    Random random = new Random();
  
    for (; i < array.GetLength(0); i++)
    {
        for (; j < array.GetLength(1); j++)
        {
            for (; k < array.GetLength(2); k++)
            {
                
                if (digit != array[i, j, k ])
                {
                    return digit;
                }
                else
                {
                    digit = random.Next(0, 21);
                    return Recursion(array,digit, i, j, k);
                }

            }
        }
    }
    return  0;
}

void FillMatrix(int[,,] matrix)
{
    Random random = new Random();
    for (int f = 0; f < matrix.GetLength(0); f++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                //int number = random.Next(0, 21);

                matrix[f, m, l] = Recursion(matrix,matrix[f,m,l], f, m, l);


            }
        }
    }
}



void PrintMatrix(int[,,] matrix)
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