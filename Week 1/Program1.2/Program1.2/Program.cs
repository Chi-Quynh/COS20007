using System;

namespace Program1._2
{
    public static class Program
    {


    public static void Main(string[] args)
    {

        Message[] messages = new Message[4];
        messages[0] = new Message("Welcome back!");
        messages[1] = new Message("What a bad name");
        messages[2] = new Message("Great name");
        messages[3] = new Message("Who are you?");

        Message myMessage = new Message("----- Hello World ----");
        myMessage.Print();

        Console.WriteLine("Enter name:");
        string line = Console.ReadLine();

        if (!string.IsNullOrEmpty(line))
        {
            switch (line)
            {
                case "Chi":
                    messages[0].Print();
                    break;
                case "Nhat":
                    messages[1].Print();
                    break;
                case "Linh":
                    messages[2].Print();
                    break;
                default:
                    messages[3].Print();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error, please re-enter your value");
        }

    }
    }



}
