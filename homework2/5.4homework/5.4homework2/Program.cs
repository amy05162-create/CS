namespace _5._4homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字：");
            int value = int.Parse(Console.ReadLine());

    
            var result = Enumerable.Range(1, value)  
                //產生1->i使用者輸入
                .Reverse()
                //把使用者輸入的數字反過來
                .Select((num, index) => new string(num.ToString()[0], index + 1)                
                // num 是數字，index 是索引 (0, 1, 2...                                                                               
                // index + 1 就是重複次數
                );

            Console.WriteLine(string.Join("\n", result));
        }

    }
}
