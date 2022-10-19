int a = 45, b = 3, c = 150;

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