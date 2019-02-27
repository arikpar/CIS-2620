//Gabe Sorenson
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvileRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int contLast, contCurr;      
            while (true)
            {        
                Console.WriteLine("Enter the number of contestants entered in last year's competition: ");
                contLast = Int32.Parse(Console.ReadLine());

                if (contLast < 0 || contLast > 30)
                {
                    Console.WriteLine("Error. Please enter a value between 0 and 30.");
                }         
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter the number of contestants entered in this year's competition: ");
                contCurr = Int32.Parse(Console.ReadLine());

                if (contCurr < 0 || contCurr > 30)
                {
                    Console.WriteLine("Error. Please enter a value between 0 and 30.");
                }

                else
                {
                    break;
                }
            }

            if ((contLast >= 0) && (contLast <= 30) && (contCurr >= 0) && (contCurr <= 30))
                Console.WriteLine("The revenue expected for this year's competition: $" + contCurr * 25 + '\n');

            if (contCurr > contLast * 2)
                Console.WriteLine("The competition is more than twice as big this year!\n");

            else
            if (contCurr > contLast && contCurr <= (contLast * 2))
                Console.WriteLine("The competition is bigger than ever!\n");

            else
            if (contCurr < contLast)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!\n");

            else

                Console.WriteLine("Please enter a valid value\n");
            Console.ReadLine();
        }
    }
}
