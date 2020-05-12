using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals.Contains(false))
                {
                    return true;
                }
            }
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if(numbers ==  null || numbers.Count() == 0) // if list is empty...
            {
                return false;
            }
            var sum = numbers.Sum(); // make var using Sum method from Linq
            return (sum % 2 != 0);
            // var sum = 0; (My answer)
            //  if (numbers.Sum() != 0)
            //  {
            //      return true;
            //  }
            //  return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isNumber = true;
                }
                if(char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if(char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
                if (isLower == true && isUpper == true && isNumber == true)
                {
                    return true;
                }
                
            }
            
                return false;
            
            //if (!password.Contains(IsUpper().IsLower().IsDigit()))
            //{
            //  return;
            //}
            //return true;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First(); //val[0] (alternate)
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last(); // return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
        

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            // return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if(i% 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // var str = words[];
            // return str.ToUpper();
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper(); // Method returns void(?)
            }
        }
        
    }
}
