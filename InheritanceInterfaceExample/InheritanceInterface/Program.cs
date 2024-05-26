using System;
using System.Collections.Generic;

namespace InheritanceInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFirstInterface> firstInterfaces = new List<IFirstInterface>();
            List<ISecondInterface> secondInterfaces = new List<ISecondInterface>();

            var user1 = new FirstChild { Username = "username1" };
            var user2 = new SecondChild { Username = "username2" };
            var user3 = new ThirdChild { Username = "username3" };

            firstInterfaces.Add(user1);
            firstInterfaces.Add(user3);

            secondInterfaces.Add(user1);
            secondInterfaces.Add(user2);

            foreach (var item in firstInterfaces)
            {
                Console.WriteLine(item.Username);
            }

            Console.WriteLine("**********");

            foreach (var item in secondInterfaces)
            {
                Console.WriteLine(item.Username);
            }

            Console.ReadLine();
        }
    }
}