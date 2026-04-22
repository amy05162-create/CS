namespace ConditionDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;
            int value;
            Console.WriteLine("請輸入一個數字");
            string input = Console.ReadLine();
            value = int.Parse(input);
            if (value > condition)
            {
                Console.WriteLine($"輸入的數字 {value} 大於 {condition}");
            }
            else if (value < condition)
            {
                Console.WriteLine($"輸入的數字 {value} 小於 {condition}");
            }
            else
            {
                Console.WriteLine($"輸入的數字 {value} 等於 {condition}");
            }
            Console.WriteLine("Hello, World!");
            
          
        }
    }
}
