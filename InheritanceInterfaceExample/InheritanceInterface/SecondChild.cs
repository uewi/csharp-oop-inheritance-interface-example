namespace InheritanceInterface
{
    public class SecondChild : Parent, ISecondInterface
    {
        public int Num { get; set; }

        public void H()
        {
            Number -= 1;
        }
    }
}