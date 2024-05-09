using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy; 


        public DataAnalyser(SummaryStrategy strategy) :
            this(strategy, new List<int>())
        {
        }


        public DataAnalyser() :
            this(new AverageSummary(), new List<int>())
        {
        }


        public DataAnalyser(List<int> numbers) :
            this(new AverageSummary(), numbers)
        {
        }

        public DataAnalyser(SummaryStrategy strategy, List<int> numbers)
        {
            _strategy = strategy;
            _numbers = numbers;
        }


        public SummaryStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }



        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }

        public void AddNumbers(int number)
        {
            _numbers.Add(number);
        }
    }
}