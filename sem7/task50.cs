int[,] RandomArrayGenerator(int min, int max)
{
    int row = new Random().Next(1, 8);
    int col = new Random().Next(1, 8);

    int[,] matrix = new int[row,col];
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max+1);
        }        
    }
    return matrix;
}

void ArrayPrint(int[,] matrix)
{
    Console.WriteLine("Все элементы нового массива: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        } 
        Console.WriteLine();               
    }
}

void FindElementInMatrix(int[,] matrix, int row, int col)
{
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент с индексом [{row},{col}] = {matrix[row, col]}");
    }
    else
    {
        Console.Write("Выход за пределы массива!");
    }
}
    
Console.WriteLine("Введите минимальный элемент массива:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент массива:");
int intMax = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс строки элемента массива:");
int intRowIndex = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс столбца элемента массива:");
int intColIndex = int.Parse(Console.ReadLine()!);

if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    int[,] array2D = RandomArrayGenerator(intMin, intMax);
    ArrayPrint(array2D);
    FindElementInMatrix(array2D, intRowIndex, intColIndex);
}

