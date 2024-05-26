using System;

namespace InheritanceInterface
{
    public class ThirdChild : Parent, IFirstInterface
    {
        public void A()
        {
            Console.WriteLine("hi");
        }

        public void F()
        {
            Number -= 1;
        }

        public void G()
        {
            Number += 1;
        }
    }
}