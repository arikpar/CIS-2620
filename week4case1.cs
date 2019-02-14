//Arik Parenteau
//

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        const double ENTRY_FEE = 25;
        int numThisYear, numLastYear;
        double revenue;

        WriteLine("Enter how many contestants were in last years Greenville" +
            " Idol competition:");
        numLastYear = int.Parse(ReadLine());
        WriteLine("Enter how many contestants there are this year:");
        numThisYear = int.Parse(ReadLine());

        WriteLine("\nYou entered {0} Greenville Idol contestants last year and {1} " +
            "contestants this year.", numLastYear, numThisYear);
        revenue = numThisYear * ENTRY_FEE;
        WriteLine("Revenue expected this year: {0}",
            revenue.ToString("C"));

        if (numThisYear > (numLastYear * 2))
        {
            WriteLine("The competition is more than twice as big this year!");
        }
        else if (numThisYear > numLastYear)
        {
            WriteLine("The competition is bigger than ever!");
        }
        else if (numThisYear < numLastYear)
        {
            WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else
        {
            WriteLine("The competition is the same size as last year.");
        }

    }
}
