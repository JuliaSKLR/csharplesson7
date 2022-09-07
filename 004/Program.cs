// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindIndexMinElements(int[,] array)
{
    int[] answer = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[answer[0], answer[1]])
            {
                answer[0] = i;
                answer[1] = j;
            }
        }
    }
    return answer;
}

int[,] DeleteMinElement(int[,] array)
{
    int[] indexes = FindIndexMinElements(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != indexes[0] && j != indexes[1])
            {
                result[k, l] = array[i, j];
                l++;
            }
        }
        if (i != indexes[0]) k++;

    }
    return result;
}

int[,] array = CreateMatrix(5, 5);
PrintArray(array);
Console.WriteLine();
int[,] newarray = DeleteMinElement(array);
PrintArray(newarray);
Console.WriteLine();