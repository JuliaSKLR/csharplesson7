//  Составить частотный словарь элементов двумерного массива. 
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
//  Значения элементов массива 0..9


int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
void PrintArray2(int[] matrix)
{
    for (int i = 0; i < 10; i++)
    {
        
        Console.Write($"{i} = {matrix[i]}\t");
       
       
    }
}

int[] FrequencyDictionary(int[,] array)
{
    int[] dictionary = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            dictionary[array[i,j]]++;

        }
    }
    return dictionary;

}

int[,] array = CreateMatrix(5,5);
PrintArray(array);
System.Console.WriteLine();
int[]result = FrequencyDictionary(array);
PrintArray2(result);
