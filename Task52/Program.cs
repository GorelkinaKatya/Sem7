void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

void CountAverage(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        double count = 0;
        double average = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[j, i];
            count++;
        }
        average = sum / count;
        Console.Write($"{Math.Round(average, 1)} ");
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
CountAverage(matrix);