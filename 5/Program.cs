﻿Console.WriteLine("Показать четные числа от 1 до ...");
Console.Write("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());

        int res = 1;
       
        if (res == 1)

        {
         res += 1;
        }

        while (res <= num)

        {
            Console.WriteLine(res);
            res += 2;
        }
