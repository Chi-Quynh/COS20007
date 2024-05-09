using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{

        public class AverageSummary : SummaryStrategy
        {
            public override void PrintSummary(List<int> numbers)
            {
                Console.WriteLine($"Average: {Average(numbers)}");
            }

            public float Average(List<int> numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                float result = (float)sum/ numbers.Count;
            return result;
            }
        }
 }