using System;

namespace HelloMethods2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("gr");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}