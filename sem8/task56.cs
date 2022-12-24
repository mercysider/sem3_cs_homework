Console.WriteLine("Введите минимальный элемент массива:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент массива:");
int intMax = int.Parse(Console.ReadLine()!);

if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    int[,] array2D = RandomMatrixGenerator(intMin, intMax);
    PrintMatrix(array2D);
    PrintMinRowInMatrix(array2D);
}

int[,] RandomMatrixGenerator(int min, int max)
{
    int row = new Random().Next(4, 6);
    int col = new Random().Next(4, 6);

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

void PrintMatrix(int[,] matrix)
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

void PrintMinRowInMatrix (int[,] matrix)
{
    int minRowSum = 0;
    int minIndex = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minRowSum += matrix[0,j];
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i,j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {minRowSum} под номером {minIndex}");
}