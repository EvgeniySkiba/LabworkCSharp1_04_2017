using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Program
    {
        /// <summary>
        /// compare two digits 
        /// </summary>
        /// <param name="fisrtDigit">first param</param>
        /// <param name="lastDigits"></param>
        /// <returns>1 - first num bigger , 2 - second num bigger, 0 - equal </returns>
        public static int compareIntDigits(int fisrtDigit, int lastDigits)
        {
            if (fisrtDigit == 0 && lastDigits == 0)
                return 0;

            if (fisrtDigit - lastDigits > 0)
                return 1;
            else return -1;
        }

        static int  Main(string[] args)
        {
            System.Console.WriteLine("Compare to digits digits: ");
            System.Console.WriteLine("Enter q for quit ");

            String line;
            int firstDigit ;
            int secondDigit;
            do
            {
                Console.WriteLine("Please enter the first digit : ");
                line = Console.ReadLine();

                if (line == "q")
                {                 
                    return 1;
                }

            } while (!int.TryParse(line, out firstDigit));

           
            line = String.Empty;
            do
            {
                Console.WriteLine("Please enter the second  digit : ");

                if (line == "q")
                {
                    return 1;
                }

                line = Console.ReadLine();
            } while (!int.TryParse(line, out secondDigit));

            int result = compareIntDigits(firstDigit,secondDigit);
            switch (result)
            {
                case 1:
                    Console.WriteLine("The first digits are bigger than second ");
                break;

                case -1:
                Console.WriteLine("The second digits are bigger than first ");
                break;

                default:
                Console.WriteLine("The digits are equal");
                break;
            }


            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
            return 0;
        }
    }
}
