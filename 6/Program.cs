Console.Clear();
System.Console.WriteLine();

int number  = new Random().Next(1, 1000);

System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
System.Console.WriteLine();