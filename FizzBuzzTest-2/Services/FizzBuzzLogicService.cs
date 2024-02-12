using FizzBuzzTest_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest_2.Services
{

    public class FizzBuzzLogicService
    {
        private readonly List<IRule> rules;

        public FizzBuzzLogicService(List<IRule> rules)
        {
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
        }

        public string GetFizzBuzz(int n)
        {
            foreach (var rule in rules)
            {
                if (rule.Matches(n))
                    return rule.GetReplacement();
            }
            return n.ToString();

        }
    }
}


