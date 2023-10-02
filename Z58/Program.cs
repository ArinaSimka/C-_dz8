// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int nRow = GetNumber("кол-ва строк");
int nCol = GetNumber("кол-ва столбцов");

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

int[,] result1 = GetMatrix(nRow, nCol);
int[,] result2 = GetMatrix(nRow, nCol);
PrintMatrix(result1);
Console.WriteLine();
PrintMatrix(result2);

int[,] CreateProizvMatrix(int nRow, int nCol, int[,] result1, int[,] result2)
{
    int[,] matrix = new int[nRow, nCol];
    for (int i = 0; i < nRow; i++)
    {
        for (int j = 0; j < nCol; j++)
        {
            matrix[i, j] = result1[i, j] * result2[i, j];
        }
    }
    return matrix;
}

int[,] matrix = CreateProizvMatrix(nRow, nCol, result1, result2);
PrintMatrix(matrix);





