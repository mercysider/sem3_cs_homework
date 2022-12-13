//здесь использовал консоль, для выдачи сообщения пользователю об ошибке
int StrToInt(string userNum)
{
    int intNum;
    if (int.TryParse(userNum, out intNum) == false)
    {
        Console.WriteLine("Вы ввели не число типа int! Число в рамках задачи будет приравнено 2!");
        return 2;
    }
    else return intNum;
}

int[] ArrayGenerator(int Size, int Min, int Max)
{
    int[] array = new int[Size];
    array[0] = Min;
    array[Size-1] = Max;
    
    for (int i = 1; i < Size-1; i++)
    {
        array[i] = new Random().Next(Min, Max+1);
    }

    Array.Sort(array);

    return array;
}

void ArrayPrint(int[] array)
    {
        Console.WriteLine("Все элементы нового массива: ");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length-1]}");
    }
    
Console.WriteLine("Введите размерность массива:");
string userSize = Console.ReadLine()!;
int intSize = StrToInt(userSize);

Console.WriteLine("Введите минимальный элемент массива:");
string userMin = Console.ReadLine()!;
int intMin = StrToInt(userMin);

Console.WriteLine("Введите максимальный элемент массива:");
string userMax = Console.ReadLine()!;
int intMax = StrToInt(userMax);

if (intSize < 2) 
{
    intSize = 2;
    Console.WriteLine("Минимальная размерность массива для данной задачи = 2! Значение размерности массива изменено на 2.");
}

if (intMin > intMax) Console.WriteLine("Минимальное значение не может быть больше максимального!");
else
{
    int[] NewArray = ArrayGenerator(intSize, intMin, intMax);
    ArrayPrint(NewArray);
}