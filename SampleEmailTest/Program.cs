using System;
namespace SampleEmailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();
            EmailTest test = new EmailTest();
            bool result = test.RegexEmailTest(email);
            Console.WriteLine(email+"  "+result);
        }
    }
}
