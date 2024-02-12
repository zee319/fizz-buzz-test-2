using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest_2.Services
{
    public class FizzBuzzLogicService
    {
        public string GetFizzBuzz(int n)
        {
            string result = n.ToString();
            if (n % 3 == 0)
            {
                result = "Fizz";
            }
            if (n % 5 == 0)
            {
                result = "Buzz";
            }
            if (n % 3 == 0 && n % 5 == 0)
            {
                result = "FizzBuzz";
            }

            return result;
        }
    }
}
