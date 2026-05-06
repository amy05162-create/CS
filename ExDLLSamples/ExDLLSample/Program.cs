using MyLibrary;
namespace ExDLLSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle() { Width = 25, Heigth = 7 };
            Console.WriteLine($"矩形面積:{rect.GetArea()}");
            Console.ReadLine();
        }
    }
}
