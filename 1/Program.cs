Console.WriteLine("Является ли первое число квадратом второго?");
int a;
Console.Write("Введите число 1 : ");
 a = int.Parse(Console.ReadLine());
int b;
Console.Write("Введите число 2 : ");
 b = int.Parse(Console.ReadLine());
 

if (b == a * a)

{
    Console.WriteLine ("Да, вляется");
}
else
{
    Console.WriteLine ("Нет, не является");
}