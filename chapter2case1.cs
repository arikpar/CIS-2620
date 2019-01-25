//Arik Parenteau
//Gabe Sorenson

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        const double ENTRY_FEE = 25;
        int numThisYear, numLastYear;
        double revenue;
        bool moreContestantsThisYear;

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
        moreContestantsThisYear = numThisYear > numLastYear;
        WriteLine("There are more contestants this year than last year: {0}",
            moreContestantsThisYear);

    }
}
