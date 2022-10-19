Console.WriteLine("Найти максимальное из трех чисел");
int a;
Console.Write("Введите число 1 : ");
 a = int.Parse(Console.ReadLine());
int b;
Console.Write("Введите число 2 : ");
 b = int.Parse(Console.ReadLine());
 int c;
Console.Write("Введите число 3 : ");
 c = int.Parse(Console.ReadLine());

int max;
if (a >= b)
 {
    if (c >= a)
    { max = c;}
    else
    {
       max = a;
    }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
 }

Console.WriteLine ($"Максимальное число равно: {max}");