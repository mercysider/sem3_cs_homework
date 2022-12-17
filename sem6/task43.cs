void FindCrossPointFor2Lines(double k1, double b1, double k2, double b2)  
{
    double x = 0;
    double y = 0;

    string outb1 = "";
    string outb2 = "";

    if (b1 < 0) outb1 = $"{b1}";
    else if (b1 > 0) outb1 = $"+{b1}";

    if (b2 < 0) outb2 = $"{b2}";
    else if (b2 > 0) outb2 = $"+{b2}";

    if (k1 == k2) 
    {
        if (b1 == b2) Console.WriteLine($"Прямые y={k1}x{outb1} и y={k2}x{outb2} совпадают!");
        else Console.WriteLine($"Прямые y={k1}x{outb1} и y={k2}x{outb2} параллельны!");
    } 
    else 
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);

        Console.WriteLine($"Точка пересечения для прямых y={k1}x{outb1} и y={k2}x{outb2}: ({x}, {y})"); 
    }      
}  
    
Console.Write("Введите значение k1 для уравнения y=k1*x+b1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите значение b1 для уравнения y={k1}*x+b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2 для уравнения y=k2*x+b2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите значение b2 для уравнения y={k2}*x+b2: ");
double b2 = double.Parse(Console.ReadLine()!);

FindCrossPointFor2Lines(k1, b1, k2, b2);