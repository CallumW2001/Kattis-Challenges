
using System.Runtime.Serialization;


int statuesToPrint = int.Parse(Console.ReadLine());
int numberOfPrinters = 1;
int days = 0;
if(statuesToPrint == 1)
{
    days = days + 1;
    Console.WriteLine(days);
}

else if(statuesToPrint > 0)
{

    while(numberOfPrinters < statuesToPrint)
    {
        numberOfPrinters = numberOfPrinters * 2;
        days = days + 1;
    }

    days = days + 1;

    Console.WriteLine(days);
}