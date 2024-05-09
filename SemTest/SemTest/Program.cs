using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxSummary minmax = new MinMaxSummary();
            AverageSummary averagesummary = new AverageSummary();

            Console.WriteLine("Dang Quynh Chi\n103805253\nSem Test");

            List<int> id = new List<int> { 1, 0, 3, 8, 0, 5, 2, 5, 3 };
            DataAnalyser dataanalyser = new DataAnalyser(minmax, id);


            dataanalyser.Summarise();


            dataanalyser.AddNumbers(19);
            dataanalyser.AddNumbers(20);
            dataanalyser.AddNumbers(25);


            dataanalyser.Strategy = averagesummary;


            dataanalyser.Summarise();
        }
    }
}