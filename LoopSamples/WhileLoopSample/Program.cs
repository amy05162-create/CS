namespace WhileLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 0;
            while(i<11)
            {
                result = result + i;
                i= i + 1;

            }
            Console.WriteLine($"加總結果:{result}");
            Console.ReadLine();
        }
    }
}
