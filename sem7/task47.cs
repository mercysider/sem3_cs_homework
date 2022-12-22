double[,] ArrayGenerator(int row, int col, int min, int max)
{
    double[,] matrix = new double[row,col];
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }        
    }
    return matrix;
}

void ArrayPrint(double[,] matrix)
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
    
Console.WriteLine("Введите кол-во строк массива:");
int intRow = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кол-во столбцов массива:");
int intCol = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальный элемент массива:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент массива:");
int intMax = int.Parse(Console.ReadLine()!);


if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    double[,] array2D = ArrayGenerator(intRow, intCol, intMin, intMax);
    ArrayPrint(array2D);
}