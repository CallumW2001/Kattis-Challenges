using System;
using System.Collections.Generic;

int firstPlayer = int.Parse(Console.ReadLine());
int count = 0;
int factor = 2;



while (factor * factor <= firstPlayer)
{
    if (firstPlayer % factor == 0)
    {

        firstPlayer /= factor;
        count++;

    }
    else factor++;
}

count++;
Console.WriteLine(count);
