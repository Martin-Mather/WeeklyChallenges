using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();

            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
           return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;

        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
           return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            //throw new NotImplementedException();
            var evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) ;
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
            return (number <= 0) ? 0 : number / 2;
            //if(number <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}
        }
    }
}
