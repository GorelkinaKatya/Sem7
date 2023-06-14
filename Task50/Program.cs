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

string FindElement(int[,] matrix, int n, int m)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == n - 1 && j == m - 1)
                return $"{matrix[i, j]}";
        }
    }
    return "Такой позиции нет";
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int n = position[0];
int m = position[1];
Console.WriteLine($"Результат: {FindElement(matrix, n, m)}");
