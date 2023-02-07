

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution(1): Hello, World!");
            string stg = "Hello, World!";
            Console.WriteLine("Solution(2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + UserName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);
        }
    }
}
