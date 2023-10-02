// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] GetMatrix(int min, int max)
{
    int[,,] matrix = new int[2, 2, 2];
    Random rand=new Random((DateTime.Now.Ticks));
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                int temp = rand.Next(min, max + 1);
                if (temp != matrix[i, j, l])
                {
                    matrix[i, j, l] = temp;
                }
                else
                { temp = rand.Next(min, max + 1); }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[i, l, j]}({i},{l},{j})  "); //+"\t"
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] matrix = GetMatrix(10, 99);
PrintMatrix(matrix);


