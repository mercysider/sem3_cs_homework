Console.WriteLine("Введите минимальный элемент матриц:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент матриц:");
int intMax = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число столбцов первой матрицы и число строк второй матрицы:");
int intСommon = int.Parse(Console.ReadLine()!);

if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    int[,] firstMatrix = FirstMatrixGenerator(intMin, intMax, intСommon);
    int[,] secondMatrix = SecondMatrixGenerator(intMin, intMax, intСommon);
    Console.WriteLine("Первая матрица:");
    PrintMatrix(firstMatrix);
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(secondMatrix);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(CreateMultiMatrix(firstMatrix, secondMatrix));
}

int[,] FirstMatrixGenerator(int min, int max, int colQty)
{
    int row = new Random().Next(2, 5);
    int col = colQty;

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

int[,] SecondMatrixGenerator(int min, int max, int rowQty)
{
    int row = rowQty;
    int col = new Random().Next(2, 5);

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        } 
        Console.WriteLine();               
    }
}

int[,] CreateMultiMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    int row1 = firstMatrix.GetLength(0);
    int col1 = firstMatrix.GetLength(1);
    int row2 = secondMatrix.GetLength(0);
    int col2 = secondMatrix.GetLength(1);

    int[,] matrix = new int[row1,col2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            for (int k = 0; k < col1; k++)
            {
                matrix[i,j] += firstMatrix[i,k]*secondMatrix[k,j];
            }
        }
    }

    return matrix;
}