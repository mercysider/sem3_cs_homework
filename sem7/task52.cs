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

void Array2DPrint(int[,] matrix)
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

void ArrayPrint(double[] array)
{
    Console.WriteLine("Среднее арифмитическое каждого столбца исходного массива: ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    } 
    Console.Write($"{array[array.Length-1]}");               
}

double[] FindAverageValuesOfColumns(int[,] matrix)
{
    double[] averageValues = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double columnSum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            columnSum += matrix[j,i]; 
        }
        
        averageValues[i] = Math.Round(columnSum / matrix.GetLength(0), 2);
    }
    return averageValues;
}
    
Console.WriteLine("Введите минимальный элемент массива:");
int intMin = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальный элемент массива:");
int intMax = int.Parse(Console.ReadLine()!);

if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    int[,] array2D = RandomArrayGenerator(intMin, intMax);
    Array2DPrint(array2D);
    FindAverageValuesOfColumns(array2D);
    ArrayPrint(FindAverageValuesOfColumns(array2D));
}

