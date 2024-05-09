using System;

namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void UserPoints(){
            try
            {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
        
            point.Move(new Point(100, 200));
            System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Bad");
            }
        }
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            Console.WriteLine(number);
            else
            Console.WriteLine("Conversion failed");
        }

        static void UserParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(new int[]{1,2,3,4,5}));

        }
    }
}