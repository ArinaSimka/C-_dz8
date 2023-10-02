//Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы  каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int nRow, int nCol, int min = 0, int max = 9)
{
    int[,] matrix = new int[nRow, nCol];
    Random rand = new Random();
    for (int i = 0; i < nRow; i++)
    {
        for (int j = 0; j < nCol; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]}    "); //+"\t"
        }
        Console.WriteLine();
    }
}
int[,] Arrange(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

int nRow = GetNumber("кол-ва строк");
int nCol = GetNumber("кол-ва столбцов");
int[,] rezult = GetMatrix(nRow, nCol);
PrintMatrix(rezult);
Console.WriteLine();
int[,] rezult2 = Arrange(rezult);
PrintMatrix(rezult2);
