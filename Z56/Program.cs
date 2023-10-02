// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int nRow, int nCol, int min = 0, int max = 5)
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

int[] Summa(int[,] matrix)
{
    int[] list = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
        }
    }
    return list;
}
int FindMinIndex(int[] array)
    {
        int minIndex = 0;
        int minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

int nRow = GetNumber("кол-ва строк");
int nCol = GetNumber("кол-ва столбцов");
int[,] rezult = GetMatrix(nRow, nCol);
PrintMatrix(rezult);
int[] list = Summa(rezult);
int i = FindMinIndex(list);
Console.WriteLine($"{i+1} строка");



   








