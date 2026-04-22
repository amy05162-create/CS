using System.Diagnostics.Tracing;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個英文句子");
            string input = Console.ReadLine();
            string[] words =   input.Split(' ');
            Console.WriteLine($"{input}一共有{words.Length}多少單字");
        }
    }
}
