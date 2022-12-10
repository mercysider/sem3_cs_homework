Console.WriteLine("Введите пятизначное число:");
string userNum = Console.ReadLine()!;
int intNum;

if (int.TryParse(userNum, out intNum)) // проверяем, является ли введенная строка int-ом
{
    userNum = userNum.TrimStart('-','0'); // убираем в начале введенной строки минус и нули
    if (userNum.Length != 5) Console.WriteLine("Число " + intNum + " не является пятизначным!"); // проверка на пятизначность
    else
    {
        if (userNum[0] == userNum[4] && userNum[1] == userNum[3]) Console.WriteLine("Число " + intNum + " является палиндромом");
        else Console.WriteLine("Число " + intNum + " не является палиндромом");
    }
}
else Console.WriteLine("Введено не число типа int!"); // результат проверки - ввели не число
