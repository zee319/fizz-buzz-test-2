﻿using System;
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
        public bool Matches(int number) => number % 3 == 0;
        public string GetReplacement() => "Fizz";
    }

    public class BuzzRule : IRule
    {
        public bool Matches(int number) => number % 5 == 0;
        public string GetReplacement() => "Buzz";
    }

    public class FizzBuzzRule : IRule
    {
        public bool Matches(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetReplacement() => "FizzBuzz";
    }
}