using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();
            Console.WriteLine(clock.Show());
            clock.Tick();
            Console.WriteLine(clock.Show());
        }
    }
}
