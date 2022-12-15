int[] ArrayGenerator(int Size)
{
    int[] array = new int[Size];
      
    for (int i = 0; i < Size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ArrayPrint(int[] array)
    {
        Console.WriteLine("Все элементы нового массива: ");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine($"{array[array.Length-1]}");
    }

int QtyOfEven(int[] array)  
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++; 
    }

    return counter;
}  
    
Console.WriteLine("Введите размерность массива:");
int intSize = int.Parse(Console.ReadLine()!);

int[] array = ArrayGenerator(intSize);
ArrayPrint(array);
Console.WriteLine($"Четных чисел: {QtyOfEven(array)}");