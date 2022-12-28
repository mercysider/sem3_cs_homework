Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersFromNumToOne(number));

string NumbersFromNumToOne(int num)
{
    if (num == 1) return $"1";
    else return $"{num}, " + NumbersFromNumToOne(num - 1);
}