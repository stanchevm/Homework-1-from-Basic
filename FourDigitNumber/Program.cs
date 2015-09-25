using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFourDigitNumber = "2011";
            int firstDigit = Convert.ToInt32(firstFourDigitNumber[0].ToString());
            int secondtDigit = Convert.ToInt32(firstFourDigitNumber[1].ToString());
            int thirdDigit = Convert.ToInt32(firstFourDigitNumber[2].ToString());
            int fourthDigit = Convert.ToInt32(firstFourDigitNumber[3].ToString());
            Console.WriteLine("{0}{1}{2}{3}", firstDigit , secondtDigit , thirdDigit , fourthDigit);

            int sum = firstDigit + secondtDigit + thirdDigit + fourthDigit;
            Console.WriteLine("{0}+{1}+{2}+{3} = {4}", firstDigit, secondtDigit, thirdDigit, fourthDigit ,sum);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit , thirdDigit ,secondtDigit , firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit , firstDigit , secondtDigit , thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit,  thirdDigit, secondtDigit,  fourthDigit);

            string secondFourDigitNumber = "3333";
            int firstDigitNumber = Convert.ToInt32(secondFourDigitNumber[0].ToString());
            int secondtDigitNumber = Convert.ToInt32(secondFourDigitNumber[1].ToString());
            int thirdDigitNumber = Convert.ToInt32(secondFourDigitNumber[2].ToString());
            int fourthDigitNumber = Convert.ToInt32(secondFourDigitNumber[3].ToString());
            Console.WriteLine("{0}{1}{2}{3}", firstDigitNumber, secondtDigitNumber, thirdDigitNumber, fourthDigitNumber);

            int secondSum = firstDigitNumber + secondtDigitNumber + thirdDigitNumber + fourthDigitNumber;
            Console.WriteLine("{0}+{1}+{2}+{3} = {4}", firstDigitNumber, secondtDigitNumber, thirdDigitNumber, fourthDigitNumber, secondSum);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigitNumber, thirdDigitNumber, secondtDigitNumber, firstDigitNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigitNumber, firstDigitNumber, secondtDigitNumber, thirdDigitNumber);
            Console.WriteLine("{0}{1}{2}{3}", firstDigitNumber, thirdDigitNumber, secondtDigitNumber, fourthDigitNumber);

            string ThirdFourDigitNumber = "9876";
            int firDigit = Convert.ToInt32(ThirdFourDigitNumber[0].ToString());
            int secDigit = Convert.ToInt32(ThirdFourDigitNumber[1].ToString());
            int thirDigit = Convert.ToInt32(ThirdFourDigitNumber[2].ToString());
            int fouDigit = Convert.ToInt32(ThirdFourDigitNumber[3].ToString());
            Console.WriteLine("{0}{1}{2}{3}", firDigit, secDigit, thirDigit, fouDigit);

            int thirdSum = firDigit + secDigit + thirDigit + fouDigit;
            Console.WriteLine("{0}+{1}+{2}+{3} = {4}", firDigit, secDigit, thirDigit, fouDigit, thirdSum);
            Console.WriteLine("{0}{1}{2}{3}", fouDigit, thirDigit, secDigit, firDigit);
            Console.WriteLine("{0}{1}{2}{3}", fouDigit, firDigit, secDigit, thirDigit);
            Console.WriteLine("{0}{1}{2}{3}", firDigit, thirDigit, secDigit, fouDigit);

        }
    }
}
