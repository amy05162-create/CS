namespace ConditionalOperatorSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            string y1 = "abc";
            int x2 = 10;
            string y2 = "abc";

            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("都正確");
            }
            else
            {
                Console.WriteLine("至少一個不正確");
            }

            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("至少一個正確");
            }
            else
            {
                Console.WriteLine("兩個都不正確");
            }

        }
    }
}
