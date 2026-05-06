namespace _5._4homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字請用逗號分開：");

            var result = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .OrderByDescending((x) => x);
            //輸入一串文字，用逗點分開，把每一個select字串變成整數，

            Console.WriteLine(string.Join(",", result));
            //加入,號輸出結果

        }
    }
}
