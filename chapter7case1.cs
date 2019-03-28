//Arik Parenteau
//

using System;
using static System.Console;
namespace GreenvileRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int contLast, contCurr;
  
            WriteLine("Last Year's Competition");
            contLast = GetContestantNum();

            WriteLine("This Year's Competition");
            contCurr = GetContestantNum();

            //CHAPTER 7

            //Parallel arrays of the names of contestants and their talent
            string[] names = new string[contCurr];
            char[] talents = new char[contCurr];

            //Parallel arrays of the talent codes, the talent, and the count of each talent
            int[] count = { 0, 0, 0, 0 };
            string[] talentOptions = { "Singing", "Dancing", "Playing an Instrument", "Other" };
            char[] talentOptionsCode = { 'S', 'D', 'M', 'O' };

            //Get the names and talents for the contestants this year
            RegisterContestants(names, talents, count);

            //Outputs count of participants with a certain talent
            for (int k = 0; k < talentOptions.Length; ++k)
            {
                WriteLine("The count of contestants with a talent of {0}: {1}",
                    talentOptions[k], count[k].ToString());
            }

            //Prompts user to enter a talent code to list who all is using said talent
            CheckTalentCount(talentOptionsCode, talents, names);


            //Outputs expected revenue for this year's competition
            if ((contLast >= 0) && (contLast <= 30) && (contCurr >= 0) && (contCurr <= 30))
                WriteLine("\nThe revenue expected for this year's competition: $" + contCurr * 25 + '\n');

            //Compares this years contestant numbers to last years
            PrintComparedContestants(contLast, contCurr);
        }

        //Function to get user input for number of contestants
        private static int GetContestantNum()
        {
            int userInput = -1;

            while (userInput < 0 || userInput > 30)
            {
                WriteLine("Enter the number of contestants: ");
                userInput = Int32.Parse(ReadLine());

                if (userInput < 0 || userInput > 30)
                {
                    WriteLine("Error. Please enter a value between 0 and 30.");
                }
            }
            return userInput;
        }


        //METHODS:
        //Method that takes two contestant values and compares them
        private static void PrintComparedContestants(int contLast, int contCurr)
        {
            if (contCurr > contLast * 2)
                WriteLine("The competition is more than twice as big this year!\n");

            else if (contCurr > contLast)
                WriteLine("The competition is bigger than ever!\n");

            else if (contCurr < contLast)
                WriteLine("A tighter race this year! Come out and cast your vote!\n");

            else
                WriteLine("There are the same number of contestants this year as there was last Year.");
        }
        //Method that takes contestants names as user input, stores them in arrays, and records talent code count
        private static void RegisterContestants(string[] namesArray, char[] talentsArray, int[] countArray)
        {
            for (int i = 0; i < namesArray.Length; ++i)
            {
                WriteLine("Enter the name for contestant number {0}:", i + 1);
                namesArray[i] = ReadLine();

                WriteLine("Enter 'S' for singing, 'D' for dancing, 'M' for playing an instrument, or 'O' for other:");
                talentsArray[i] = Convert.ToChar(ReadLine());
                while (talentsArray[i] != 'S' && talentsArray[i] != 'D' && talentsArray[i] != 'M' && talentsArray[i] != 'O')
                {
                    WriteLine("ERROR: Invalid Entry. Make sure to enter letter as uppercase\n" +
                        "Enter 'S' for singing, 'D' for dancing, 'M' for playing an instrument, or 'O' for other:");
                    talentsArray[i] = Convert.ToChar(ReadLine());
                }

                //Keeps count of total number of contestants with each talent
                switch (talentsArray[i])
                {
                    case 'S':
                        countArray[0] += 1;
                        break;
                    case 'D':
                        countArray[1] += 1;
                        break;
                    case 'M':
                        countArray[2] += 1;
                        break;
                    case 'O':
                        countArray[3] += 1;
                        break;
                }
            }
        }

        //Method that keeps prompting user for talent codes to display the count of
        private static void CheckTalentCount(char[] talentOptionsCode, char[] talents, string[] names)
        {
            char userInput;
            do
            {
                WriteLine("Enter a talent code (S, D, M, O) to list contestants with that talent.\n" +
                    "Or enter 'q' to quit.");
                userInput = Convert.ToChar(ReadLine());
                while (userInput != 'S' && userInput != 'D' && userInput != 'M' && userInput != 'O' &&
                    userInput != 'Q' && userInput != 'q')
                {
                    WriteLine("ERROR: invalid entry. Make sure to enter S, D, M, O, or Q to quit:");
                    userInput = Convert.ToChar(ReadLine());
                }

                //Lists names with inputted talent
                bool countNotZero = false;
                if (userInput == 'Q' || userInput == 'q')
                    break;
                WriteLine("\nContestants with talent of {0}:", userInput);
                for (int i = 0; i < talentOptionsCode.Length; ++i)
                {
                    if (talentOptionsCode[i] == userInput)
                    {

                        for (int j = 0; j < talents.Length; ++j)
                        {
                            if (talentOptionsCode[i] == talents[j])
                            {
                                WriteLine("{0}", names[j]);
                                countNotZero = true;
                            }

                        }
                    }
                }

                if (!countNotZero)
                    WriteLine("none");
                WriteLine();

            } while (userInput != 'q' && userInput != 'Q');
        }

    }
}
