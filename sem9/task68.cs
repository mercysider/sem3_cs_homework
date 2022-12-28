Console.WriteLine("Введите неотрицательное число M: ");
int firstNum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите неотрицательное число N: ");
int secondNum = int.Parse(Console.ReadLine()!);

if (firstNum < 0 || secondNum < 0) Console.WriteLine("Оба числа должны быть неотрицательными!");
else Console.WriteLine(AckermanFunction(firstNum, secondNum));

int AckermanFunction(int firstNum, int secondNum)
{
    if (firstNum == 0) return secondNum + 1;
        else 
        {
            if (secondNum == 0) return AckermanFunction(firstNum - 1, 1);
            else return AckermanFunction(firstNum - 1, AckermanFunction(firstNum, secondNum - 1));
        }
}
