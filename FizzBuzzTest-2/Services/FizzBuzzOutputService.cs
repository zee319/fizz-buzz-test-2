using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest_2.Services
{
    public class FizzBuzzOutputService
    {
        private readonly FizzBuzzLogicService _fizzBuzzLogicService;

        public FizzBuzzOutputService(FizzBuzzLogicService fizzBuzzLogicService)
        {
            _fizzBuzzLogicService = fizzBuzzLogicService ?? throw new ArgumentNullException(nameof(fizzBuzzLogicService));
        }

        public void OutputFizzBuzz(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(_fizzBuzzLogicService.GetFizzBuzz(i));
            }
        }

    }
}
