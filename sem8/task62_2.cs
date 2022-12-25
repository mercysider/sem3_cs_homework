Console.WriteLine("Задайте число строк массива:");
int intSizeY = int.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте число столбцов массива:");
int intSizeX = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[intSizeY,intSizeX];
int[,] array2D = SpiralFillingOfMatrix(matrix, 0, 1);
PrintMatrix(array2D);

// функция заполняет внешний контур массива, и запускает сама себя для следующего контура (нового внешнего)
// startPoint описывает стартовую точку для заполнения внешнего контура по часовой стрелке: [0,0] - на первом шаге, затем [1,1] и т.д.
int[,] SpiralFillingOfMatrix(int[,] matrix, int startPoint, int cellValue)
{
    int value = cellValue;
    int sizeY = matrix.GetLength(0);
    int sizeX = matrix.GetLength(1);
    int size = 0;
    if (sizeY < sizeX) size = sizeY;
    else size = sizeX;

    for (startPoint = 0; startPoint <= (size+1)/2 - 1; startPoint++)
    {
        bool nextX = false;
        bool nextY = false;
        for (int x = startPoint; x < sizeX-startPoint; x++) //строка слева направо
        {
            matrix[startPoint,x] = value;
            value++;
        }
        for (int y = startPoint+1; y < sizeY-startPoint; y++) //столбец сверху вниз
        {
            matrix[y,sizeX-startPoint-1] = value;
            value++;
            nextX = true; // разрешаем следующий проход по горизонтали
        }
        if (nextX)
        {
            for (int x = sizeX-startPoint-2; x >= startPoint; x--) //строка справа налево
            {
                matrix[sizeY-startPoint-1,x] = value;
                value++;
                nextY = true; // разрешаем следующий проход по вертикали
            }
        }
        if (nextY)
        {
            for (int y = sizeY-startPoint-2; y >= startPoint+1; y--) //столбец сверху вниз
            {
                matrix[y,startPoint] = value;
                value++;
            }
        }
    }
    
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