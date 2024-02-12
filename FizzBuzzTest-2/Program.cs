using FizzBuzzTest_2;
using FizzBuzzTest_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
     /*       Console.WriteLine("Printing FizzBuzz Results");

            FizzBuzzLogicService fizzBuzzService = new FizzBuzzLogicService();
            FizzBuzzOutputService fizzBuzzPrinter = new FizzBuzzOutputService(fizzBuzzService);

            fizzBuzzPrinter.OutputFizzBuzz(1, 100);

            Console.WriteLine("----------End---------");

            Console.ReadLine();


*/

            Console.WriteLine("Printing FizzBuzz Results");
            
            var rules = new List<IRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule()
            };

            var fizzBuzzLogicService = new FizzBuzzLogicService(rules);
            var fizzBuzzOutputService = new FizzBuzzOutputService(fizzBuzzLogicService);

            fizzBuzzOutputService.OutputFizzBuzz(1, 100);

            Console.WriteLine("----------End---------");

            Console.ReadLine();
        }
    }
}