namespace EqualitySample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine($"i.Equls(j) is {i.Equals(j)}");
            MyRectangle r1 =new MyRectangle { Width =5, Heigth=5 };
            MyRectangle r2 =new MyRectangle { Width = 5,Heigth = 5};
            MyRectangle o = r2;
            Console.WriteLine($"r1.Equals(o) is {r1.Equals(o)}");
            Console.WriteLine($"r2.Equals(r3) is {r2.Equals(r3)}");

            Console.ReadLine();



        }
    }
}
