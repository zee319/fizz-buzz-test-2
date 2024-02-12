using FizzBuzzTest_2;
using FizzBuzzTest_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing FizzBuzz Results");

            var rules = GetFizzBuzzRules();

            var fizzBuzzLogicService = new FizzBuzzLogicService(rules);
            var fizzBuzzOutputService = new FizzBuzzOutputService(fizzBuzzLogicService);

            fizzBuzzOutputService.OutputFizzBuzz(1, 100);

            Console.WriteLine("----------End---------");

            Console.ReadLine();
        }

        private static List<IRule> GetFizzBuzzRules()
        {
            var ruleTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(IRule).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            var rules = ruleTypes.Select(type => (IRule)Activator.CreateInstance(type)).ToList();
            return rules;
        }
    }
}