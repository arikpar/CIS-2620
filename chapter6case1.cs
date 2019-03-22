//Arik Parenteau
//Gabe Sorenson

using System;
using static System.Console;
namespace GreenvileRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int contLast, contCurr;
            //Loop to make sure a value between 0 and 30 is chosen for last years competition
            while (true)
            {        
                WriteLine("Enter the number of contestants entered in last year's competition: ");
                contLast = Int32.Parse(ReadLine());

                if (contLast < 0 || contLast > 30)
                {
                    WriteLine("Error. Please enter a value between 0 and 30.");
                }         
                else
                {
                    break;
                }
            }

            //Loop to make sure a value between 0 and 30 is chosen for this years competition.
            while (true)
            {
                WriteLine("Enter the number of contestants entered in this year's competition: ");
                contCurr = Int32.Parse(ReadLine());

                if (contCurr < 0 || contCurr > 30)
                {
                    WriteLine("Error. Please enter a value between 0 and 30.");
                }

                else
                {
                    break;
                }
            }
            //CHAPTER 6
            char userInput = 'x';

            //Parallel arrays of the names of contestants and their talent
            string[] names = new string[contCurr];
            char[] talents = new char[contCurr];

            //Parallel arrays of the talent codes, the talent, and the count of each talent
            int[] count = { 0, 0, 0, 0 };
            string[] talentOptions = { "Singing", "Dancing", "Playing an Instrument", "Other" };
            char[] talentOptionsCode = { 'S', 'D', 'M', 'O' };

            //Get the names and talents for the contestants this year
            for(int i = 0; i < names.Length; ++i)
            {
                WriteLine("Enter the name for contestant number {0}:", i + 1);
                names[i] = ReadLine();

                WriteLine("Enter 'S' for singing, 'D' for dancing, 'M' for playing an instrument, or 'O' for other:");
                talents[i] = Convert.ToChar(ReadLine());
                while(talents[i] != 'S' && talents[i] != 'D' && talents[i] != 'M' && talents[i] != 'O')
                {
                    WriteLine("ERROR: Invalid Entry. Make sure to enter letter as uppercase\n" +
                        "Enter 'S' for singing, 'D' for dancing, 'M' for playing an instrument, or 'O' for other:");
                    talents[i] = Convert.ToChar(ReadLine());
                }

                //Keeps count of total number of contestants with each talent
                switch (talents[i])
                {
                    case 'S':
                        count[0] += 1;
                        break;
                    case 'D':
                        count[1] += 1;
                        break;
                    case 'M':
                        count[2] += 1;
                        break;
                    case 'O':
                        count[3] += 1;
                        break;
                }
            }

            //Outputs count of participants with a certain talent
            for(int k = 0; k < talentOptions.Length; ++k)
            {
                WriteLine("The count of contestants with a talent of {0}: {1}",
                    talentOptions[k], count[k].ToString());
            }

            //Prompts user to enter a talent code to list who all is using said talent
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
                for(int i = 0; i < talentOptionsCode.Length; ++i)
                {
                    if (talentOptionsCode[i] == userInput)
                    {
                    
                        for(int j = 0; j < talents.Length; ++j)
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


            //Outputs expected revenue for this year's competition
            if ((contLast >= 0) && (contLast <= 30) && (contCurr >= 0) && (contCurr <= 30))
                WriteLine("The revenue expected for this year's competition: $" + contCurr * 25 + '\n');

            //Compares this years contestant numbers to last years
            if (contCurr > contLast * 2)
                WriteLine("The competition is more than twice as big this year!\n");

            else if (contCurr > contLast)
                WriteLine("The competition is bigger than ever!\n");

            else if (contCurr < contLast)
                WriteLine("A tighter race this year! Come out and cast your vote!\n");

            else
                WriteLine("There are the same number of contestants this year as there was last Year.");
        }
    }
}
