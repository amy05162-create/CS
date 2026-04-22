namespace SwitchDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數字");
            value=int.Parse(Console.ReadLine()); //直接用int執行
            switch (value)
            {
                case 1:
                    Console.WriteLine("數字是1");
                    break;
                case 2:
                    Console.WriteLine("數字是2");
                    break;
                default:
                    Console.WriteLine("數字是不在條件內");
                    break;
                    
            }
            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }
    }
}
