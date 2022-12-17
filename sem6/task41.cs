int EvenInUserInput(int qty)  
{
    int count = 0;

    for (int i = 0; i < qty; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        if (int.Parse(Console.ReadLine()!) > 0) count++;
    }
    return count;    
}  
    
Console.Write("Сколько чисел вы хотите ввести? ");
int intSize = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Положительных чисел: {EvenInUserInput(intSize)}");