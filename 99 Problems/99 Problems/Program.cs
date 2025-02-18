using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

int last = Last2Digits(n);

    if (n <= 99)
    {
        Console.WriteLine("99");
    }
    else
    {

        if (last < 49)
        {
            Console.WriteLine(n - (last) - 1);
        }
        else
        {
            Console.WriteLine(n + 100 - (last) - 1);
        }

    }
static int Last2Digits(int n)
{

    string num = n.ToString();
    string first;
    string second;
    int Last2Digits;

    List<char> digits = num.ToList();

    if (n >= 10)
    {
        first = digits[^2].ToString();
        second = digits[^1].ToString();
        Last2Digits = int.Parse(first + second);
        return Last2Digits;
    }
    else
    {
        return int.Parse(digits[^1].ToString());
    }
}