Console.WriteLine("Задайте число N для создания массива N x N:");
int intSize = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[intSize,intSize];
int[,] array2D = SpiralFillingOfMatrix(matrix, intSize, 0, 1);
PrintMatrix(array2D);

// функция заполняет внешний контур массива, и запускает сама себя для следующего контура (нового внешнего)
// startPoint описывает стартовую точку для заполнения внешнего контура по часовой стрелке: [0,0] - на первом шаге, затем [1,1] и т.д.
int[,] SpiralFillingOfMatrix(int[,] matrix, int size, int startPoint, int cellValue)
{
    int value = cellValue;
    
    for (int x = startPoint; x < size-startPoint; x++) //строка слева направо
    {
        matrix[startPoint,x] = value;
        value++;
    }
    for (int y = startPoint+1; y < size-startPoint; y++) //столбец сверху вниз
    {
        matrix[y,size-startPoint-1] = value;
        value++;
    }
    for (int x = size-startPoint-2; x >= startPoint; x--) //строка справа налево
    {
        matrix[size-startPoint-1,x] = value;
        value++;
    }
    for (int y = size-startPoint-2; y >= startPoint+1; y--) //столбец снизу ввверх
    {
        matrix[y,startPoint] = value;
        value++;
    }
    
    if (startPoint < size/2) SpiralFillingOfMatrix(matrix, size, startPoint + 1, value);    
    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Спиральный массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        } 
        Console.WriteLine();               
    }
}