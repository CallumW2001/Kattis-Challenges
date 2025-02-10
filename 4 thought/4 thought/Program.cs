
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

int n = Convert.ToInt32(Console.ReadLine());
List<int> answers = new List<int>();
List<Func<Tuple<int, string>>> functions = new List<Func<Tuple<int, string>>>();
functions.Add(Add);
functions.Add(Minus);
functions.Add(Multiply);
functions.Add(Division);

const int numbersCap = 4;
string Equation = "";

string[] operators = ["+", "-", "*", "/"];


for(int i = 0; i < n; i++)
{
    answers.Add(Convert.ToInt32(Console.ReadLine()));
}

for(int i = 0; i < answers.Count; i++)
{
    Equation = operations(functions, operators, answers[i]);
    Console.WriteLine(Equation);
}

static Tuple<int, string> Add()
{
    int equation = 4 + 4;
    string equationString = "4 + 4";

    return new Tuple<int, string>(equation, equationString);
}

static Tuple<int, string> Minus()
{
    int equation = 4 - 4;
    string equationString = "4 - 4";

    return new Tuple<int, string>(equation, equationString);
}

static Tuple<int, string> Multiply()
{
    int equation = 4 * 4;
    string equationString = "4 * 4";

    return new Tuple<int, string>(equation, equationString);
}

static Tuple<int, string> Division()
{
    int equation = 4 / 4;
    string equationString = "4 / 4";

    return new Tuple<int, string>(equation, equationString);
}


static string operations(List<Func<Tuple<int,string>>> functions, string[] operators, int answer)
{
    bool foundAnswer = false;
    int result = 0;
    string finalResult = "";

    if (answer >= -60 || answer < 256)
    {

        for (int i = 0; i < operators.Length; i++)
        {
            if (operators[i] == "+")
            {
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        result = functions[x]().Item1 + functions[y]().Item1;

                        if (result == answer)
                        {
                            foundAnswer = true;
                            finalResult = functions[x]().Item2 + " + " + functions[y]().Item2 + " = " + result;
                            return finalResult;
                        }
                    }
                }
            }
            else if (operators[i] == "-")
            {
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        result = functions[x]().Item1 - functions[y]().Item1;

                        if (result == answer)
                        {
                            foundAnswer = true;
                            finalResult = functions[x]().Item2 + " - " + functions[y]().Item2 + " = " + result;
                            return finalResult;
                        }
                    }
                }
            }
            else if (operators[i] == "*")
            {
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        result = functions[x]().Item1 * functions[y]().Item1;
                        if (result == answer)
                        {
                            foundAnswer = true;
                            finalResult = functions[x]().Item2 + " * " + functions[y]().Item2 + " = " + result;
                            return finalResult;
                        }
                    }
                }
            }
            else if (operators[i] == "/")
            {
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (functions[y]().Item1 != 0)
                        {
                            result = functions[x]().Item1 / functions[y]().Item1;
                            Math.Truncate((decimal)result);
                        }
                        if (result == answer)
                        {
                            foundAnswer = true;
                            finalResult = functions[x]().Item2 + " / " + functions[y]().Item2 + " = " + result;
                            return finalResult;
                        }
                    }
                }
            }
        }
    }

    return "no solution";

}