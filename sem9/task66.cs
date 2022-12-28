Console.WriteLine("Введите число M: ");
int firstNum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int secondNum = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumFromFirstToSecond(firstNum, secondNum));

int SumFromFirstToSecond(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    else return secondNum + SumFromFirstToSecond(firstNum, secondNum - 1);
}