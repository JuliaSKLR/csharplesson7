// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,]ChangeFirstAndLAstRow(int[,]array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[0,j];
            array[0,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1 , j] = temp;
        }
        return array;
    }


int [,] array = CreateMatrix(5,5);
PrintArray(array);
System.Console.WriteLine();
int[,] newarray = ChangeFirstAndLAstRow(array);
PrintArray(newarray);

