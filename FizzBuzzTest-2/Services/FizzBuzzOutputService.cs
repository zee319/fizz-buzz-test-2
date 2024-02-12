using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest_2.Services
{
    public class FizzBuzzOutputService
    {
        private readonly FizzBuzzLogicService fizzBuzzLogicService;

        public FizzBuzzOutputService(FizzBuzzLogicService fizzBuzzService)
        {
            this.fizzBuzzLogicService = fizzBuzzService;
        }

        public void OutputFizzBuzz(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(fizzBuzzLogicService.GetFizzBuzz(i));
            }
        }
    }
}
