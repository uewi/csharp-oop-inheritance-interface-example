namespace InheritanceInterface
{
    public class FirstChild : Parent, ISecondInterface, IFirstInterface
    {

        public void H()
        {
            Number -= 1;
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