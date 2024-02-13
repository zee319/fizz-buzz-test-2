using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest_2
{
   public interface IRule
    {
        bool Matches(int number);
        string GetReplacement();
    }
    public class FizzRule : IRule
    {
        public bool Matches(int number) => number % 3 == 0 && number % 5 != 0;
        public string GetReplacement() => "Fizz";
    }

    public class BuzzRule : IRule
    {
        public bool Matches(int number) => number % 5 == 0 && number % 3 != 0;
        public string GetReplacement() => "Buzz";
    }

    public class FizzBuzzRule : IRule
    {
        public bool Matches(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetReplacement() => "FizzBuzz";
    }


    //Another Implementation of these classes to demonstrate Integration Segration Principle

    /*public interface IRule
    {
        bool Matches(int number);
        string GetReplacement();
    }

    public interface IDivisibleBy3: IRule { }
    public interface IDivisibleBy5 : IRule { }
    public interface IDivisibleBy3And5 : IDivisibleBy3, IDivisibleBy5 { }


   public class FizzRule : IDivisibleBy3
    {
        public bool Matches(int number) => number % 3 == 0 && number % 5 != 0;
        public string GetReplacement() => "Fizz";
    }

    public class BuzzRule : IDivisibleBy5
    {
        public bool Matches(int number) => number % 5 == 0 && number % 3 != 0;
        public string GetReplacement() => "Buzz";
    }

    public class FizzBuzzRule : IDivisibleBy3And5
    {
        public bool Matches(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetReplacement() => "FizzBuzz";
    }*/
}
