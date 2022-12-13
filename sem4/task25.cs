//здесь использовал консоль, для выдачи сообщения польлзовтелю об ошибке
int StrToInt(string userNum)
{
    int intNum;
    if (int.TryParse(userNum, out intNum) == false)
    {
        Console.WriteLine("Вы ввели не число типа int! Число будет приравнено 0!");
        return 0;
    }
    else return intNum;
}

//здесь не использоваль консоль по условию задачи, учел вариант с отрицательной степенью
double Power(int intNum, int Pow)
{
    int i;
    double result = 1;
    if (Pow >= 0)
    {
        for (i = 1; i <= Pow; i++)
        {
            result = result * intNum;
        }
    }
    else
    {
        for (i = 1; i <= -Pow; i++)
        {
            result = result / intNum;
        }
    }
    
    return result;
}

Console.WriteLine("Введите первое число:");
string userNum1 = Console.ReadLine()!;
int intNum1 = StrToInt(userNum1);

Console.WriteLine("Введите второе число:");
string userNum2 = Console.ReadLine()!;
int intNum2 = StrToInt(userNum2);

double answer = Power(intNum1, intNum2);
Console.WriteLine($"Число {intNum1} в степени {intNum2} = {answer}");