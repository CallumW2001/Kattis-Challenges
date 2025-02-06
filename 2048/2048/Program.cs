
int[,] grid = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    string[] inputs = Console.ReadLine().Split(' ');
    for(int j = 0; j < 4; j++)
    {
        grid[i, j] = int.Parse(inputs[j]);
    }
}


int direction = Convert.ToInt32(Console.ReadLine());


bool merged = false;



if(direction == 0)
{
    for (int j = 0; j < 4; j++)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[y, i] == 0)
                {
                    grid[y, i] = grid[y, i + 1];
                    grid[y, i + 1] = 0;
                }
            }
        }

    }
    for (int y = 0; y < 4; y++)
    {
            for (int i = 0; i < 3; i++)
            {
                if (grid[y, i] == grid[y, i + 1])
                {
                    grid[y, i] = grid[y, i] * 2;
                    grid[y, i + 1] = 0;
                }
            }
    }

    for (int j = 0; j < 4; j++)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[y, i] == 0)
                {
                    grid[y, i] = grid[y, i + 1];
                    grid[y, i + 1] = 0;
                }
            }
        }

    }

}
else if(direction == 1)
{
    for (int j = 0; j < 4; j++)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, y] == 0)
                {
                    grid[i, y] = grid[i + 1, y];
                    grid[i + 1, y] = 0;
                }
            }
        }
    }

    for (int y = 0; y < 4; y++)
    {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, y] == grid[i + 1, y])
                {
                    grid[i, y] = grid[i, y] * 2;
                    grid[i + 1, y] = 0;
                }
            }
    }

    for (int j = 0; j < 4; j++)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, y] == 0)
                {
                    grid[i, y] = grid[i + 1, y];
                    grid[i + 1, y] = 0;
                }
            }
        }
    }
}



else if(direction == 2)
{

    for (int j = 0; j < 4; j++)
    {
        for (int y = 3; y >= 0; y--)
        {
            for (int i = 3; i > 0; i--)
            {
                if (grid[y, i] == 0)
                {
                    grid[y, i] = grid[y, i - 1];
                    grid[y, i - 1] = 0;
                }
            }
        }
    }

    for (int y = 3; y >= 0; y--)
    {
            for (int i = 3; i > 0; i--)
            {
                if (grid[y, i] == grid[y, i - 1])
                {
                    grid[y, i] = grid[y, i] * 2;
                    grid[y, i - 1] = 0;
                }             
            }
    }


    for (int j = 0; j < 4; j++)
    {
        for (int y = 3; y >= 0; y--)
        {
            for (int i = 3; i > 0; i--)
            {
                if (grid[y, i] == 0)
                {
                    grid[y, i] = grid[y, i - 1];
                    grid[y, i - 1] = 0;
                }
            }
        }
    }
}

else if (direction == 3)
{

    for (int j = 0; j < 4; ++j)
    {
        for (int y = 3; y >= 0; y--)
        {
            for (int i = 3; i > 0; i--)
            {
                if (grid[i, y] == 0)
                {
                    grid[i, y] = grid[i - 1, y];
                    grid[i - 1, y] = 0;
                }
            }
        }
    }

    for (int y = 3; y >= 0; y--)
    {
            for (int i = 3; i > 0; i--)
            {
                if (grid[i, y] == grid[i - 1, y])
                {
                    grid[i, y] = grid[i, y] * 2;
                    grid[i - 1, y] = 0;
                }              
            }
    }


    for (int j = 0; j < 4; ++j)
    {
        for (int y = 3; y >= 0; y--)
        {
            for (int i = 3; i > 0; i--)
            {
                if (grid[i, y] == 0)
                {
                    grid[i, y] = grid[i - 1, y];
                    grid[i - 1, y] = 0;
                }
            }
        }
    }
}


PrintGrid(grid);



static void PrintGrid(int[,] grid)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
}