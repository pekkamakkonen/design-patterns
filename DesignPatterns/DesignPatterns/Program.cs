using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Pekka");
            user.SayHello();
            // Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
