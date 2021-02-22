using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            foreach (bool i in vals)
            {
                if (i is false)
                {
                    return true;
                }
            }
            return false;


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            var sumOfOdds = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var x in numbers)
            {
                if (x % 2 != 0)
                {
                    sumOfOdds = x + sumOfOdds;
                }
            }
            if (sumOfOdds % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            foreach (var i in password)
            {
                if (char.IsLower(i))
                {
                    isLower = true;
                }
                if (char.IsUpper(i))
                {
                    isUpper = true;
                }
                if (char.IsNumber(i))
                {
                    isNumber = true;
                }
                
            }

            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
           //throw new NotImplementedException();
           return val.First();
            
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[val.Length -1];
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0)
            {
                return 0;
            }
            else
                return dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            var last = nums.Length -1;
            return nums[last] - nums[0];
        }

        public int[] GetOddsBelow100()
        {

            //throw new NotImplementedException();
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                    {
                      list.Add(i);
                    }
               
            }
            return list.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
