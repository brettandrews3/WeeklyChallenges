using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x != 0).Sum();
            //Subtracts the sum of Evens from the sum of Odds

            //  num = numbers.Where(num => numbers % 2 == 0)
          /* Want to use Linq: add even numbers, subtract the odds
           * Do I need to declare a new variable to hold the final tally?
           * How do I account for null values?
           * How can I subtract the odd numbers? */
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //Put all the strings into a list. Measure each string's Length, then return the Min from list.
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
            // Return number.Min() from this list
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //Right-click "biz" to see its declaration, then find the value for Name
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);

            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs.Where(x => x == null).Count() > objs.Length / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers) //return a double from array of int
        {
            //Do the null check before anything else
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var count2 = numbers.Where(x => x % 2 == 0).Average(); //LINQ approach
            
            if(numbers.Where(x => x % 2 == 0).Count() > 0)
            {
                return count2;
            }
            return 0;
            //Pull all even numbers from the numbers array, add them, then average
        }
        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i; //fact = fact *1
            }

            return fact;
            //return a factorial of a number; isn't there a Fact() in Linq?
        }
    }
}
