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

//здесь не использовал консоль по условию задачи, учел вариант с отрицательным числом
int SumOfDigits(int Num)
{
    int result = 0;
    if (Num < 0) Num = -Num;
    while (Num > 0)
    {
        result = result + Num % 10;
        Num = Num / 10;
    }    
    
    return result;
}

Console.WriteLine("Введите число:");
string userNum = Console.ReadLine()!;
int intNum = StrToInt(userNum);

int answer = SumOfDigits(intNum);
Console.WriteLine($"Сумма цифр в числе {intNum} = {answer}");