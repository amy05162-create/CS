using System.Numerics;

namespace IntMaximumValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("請輸入三個整數,用逗號隔開");
            //string[] input = Console.ReadLine().Split(',');
            //int[] arrnum = Array.ConvertAll(input, int.Parse);
            //int x = arrnum[0];
            //foreach(int num in arrnum)
            //{ 
            //    if(num>x)
            //    {
            //        x = num;

            //    }
            //}
            //Console.WriteLine($"最大值為:{x}");

            string[] content = Console.ReadLine().Split(',');
            /* string input = Console.ReadLine();
            string[] content = input.Split(','); */
            int[] numbers = new int[content.Length];
            
            int max = int.MinValue;

            foreach (string item in content)
            {
                int number = int.Parse(item);
                if (number > max)
                {
                    max = number;
                }

            }
            Console.WriteLine($"最大值:{max}");
            Console.ReadLine();
        }
    }
}
