int[,] FillMatrix(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = new Random().Next(0, 11);
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

void PrintMatrix(int[,] matrix)
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
    int[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
    Console.WriteLine();

    int lineSearch = (Prompt("Введите искомую строку: "));
    int columnSearch = (Prompt("Введите искомый столбец: "));
    int res = 0;
    if ((lineSearch < matrix.GetLength(0)) && (columnSearch < matrix.GetLength(1)) && lineSearch >= 0 && columnSearch >= 0)
    {
        res = matrix[lineSearch, columnSearch];
        Console.WriteLine($"Число по данным координатам: {res}");
    }
    else
    {
        Console.WriteLine("Неверные координаты!");
    }
}
else
{
    Console.WriteLine("Неверные значения!");
}