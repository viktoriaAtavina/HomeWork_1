﻿Console.Clear();
System.Console.WriteLine();

int Number = new Random().Next(100, 500);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

System.Console.WriteLine();
System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру,то получится число {NewNumber}");
System.Console.WriteLine();
