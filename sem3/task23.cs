// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
string userNum = Console.ReadLine()!;
int intNum;

if (int.TryParse(userNum, out intNum)) // проверяем, является ли введенная строка int-ом
{
    if (intNum < 1) Console.WriteLine($"Нет чисел между 1 и {intNum}");
    else
    {
        userNum = userNum.TrimStart('0'); // убираем в начале введенной строки нули, мало ли кто ввел 002 вместо 2
        Console.WriteLine($"Кубы чисел от 1 до {intNum}: ");
        for (int i = 1; i < intNum; i++)
        {
            //Console.Write($"{i*i*i} ");
            Console.Write($"{Math.Pow(i, 3)}, ");
        }
        Console.Write($"{Math.Pow(intNum, 3)}");
    }
}
else Console.WriteLine("Введено не число типа int!"); // результат проверки - ввели не число