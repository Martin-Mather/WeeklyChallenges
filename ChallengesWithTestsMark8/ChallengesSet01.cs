using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
              return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();


            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            

            return number1 + number2;

        }    





        

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            //throw new NotImplementedException();
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //Console.WriteLine($"What is your name:");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello, {nameOfPerson} !");
            if(nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return "Hello!";
            }
            //if(nameOfPerson == "John")
            //{
            //    return "Hello, John!";
            //}
            //if (nameOfPerson == "Leigh")
            //{
            //    return "Hello, Leigh!";
            //}
            //if (nameOfPerson == "John Thomas")
            //{
            //    return "Hello, John Thomas!";
            //}
            //if (nameOfPerson == "Leigh Ann")
            //{
            //    return "Hello, Leigh Ann!";
            //}
            //if (nameOfPerson == "")
            //{
            //    return "Hello!";
            //}
            //else
            //{
            //    return "false";
            //}
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
