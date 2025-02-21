using System;
using System.Collections.Generic;
using System.Linq;


string input = Console.ReadLine();
List<char> movements = input.ToList();



int pass = 0;

for(int i = 0; i < movements.Count; i++)
{

    if (movements[i] == '>')
    {
        for(int j = i; j < movements.Count; j++)
        {
            if (movements[j] == '<')
            {
                pass++;
            }
        }
    }

}

Console.WriteLine(pass);