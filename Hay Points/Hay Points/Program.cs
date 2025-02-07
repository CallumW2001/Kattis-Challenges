
List<string> haywords = new List<string>();
List<int> value = new List<int>();

string[] inputs = Console.ReadLine().Split(' ');

for (int i = 0; i < int.Parse(inputs[0]); i++)
{
    string[] positions = Console.ReadLine().Split();
    haywords.Add(positions[0]);
    value.Add(int.Parse(positions[1]));
}

for(int i = 0; i < int.Parse(inputs[1]); i++)
{
    string line = "";
    int statementValue = 0;
    while (line != '.'.ToString())
    {
            line = Console.ReadLine();
            foreach (string x in line.Split(' '))
            {
                    for (int f = 0; f < int.Parse(inputs[0]); f++)
                    {
                        if (x == haywords[f])
                        {
                            statementValue = statementValue + value[f];
                        }
                    }         
            }
    }
    Console.WriteLine(statementValue);
 
}