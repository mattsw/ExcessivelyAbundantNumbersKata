namespace ExcessivelyAbundantNumbersKata
{
    using System;
    using System.Linq;
    /*
    SRC: (http://www.codewars.com/kata/56a75b91688b49ad94000015)

        An abundant number or excessive number is a number for which the sum of its 
        proper divisors is greater than the number itself.
        The integer 12 is the first abundant number. 
        Its proper divisors are 1, 2, 3, 4 and 6 for a total of 16 (> 12).
        Derive function abundantNumber(num)/abundant_number(num) which returns true/True if num is abundant, 
        false/False if not.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsExcessiveNumber(12));
        }

        public static bool IsExcessiveNumber(int numberToCheck)
        {
            return Enumerable.Range(1, numberToCheck / 2)
                .Sum(number => numberToCheck % number == 0 ? number : 0) > numberToCheck;
        }
    }
}
