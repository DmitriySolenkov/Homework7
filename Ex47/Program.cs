double[,] FillMatrix(int length1, int length2)
{
    double[,] array = new double[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(100) / 10.0);
        }
    }
    return array;
}

int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void PrintMatrix(double[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[k, l]}\t");
        }
        Console.WriteLine();
    }
}

int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && column > 0)
{
    double[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Неверные значения!");
}