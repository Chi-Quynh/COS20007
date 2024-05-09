using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    public class MinMaxSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine($"Minium:{Minimium(numbers)}\nMaximium:{Maximium(numbers)}");
        }

        private int Minimium(List<int> numbers)
        {
            int result = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                if (number < result)
                    result = number;
            }
            return result;


        }

        private int Maximium(List<int> numbers)
        {
            int result = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                if (number > result)
                    result = number;
            }
            return result;

        }
    }
}