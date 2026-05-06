namespace MethodOverloadSample001
{
    internal class Program
    {
        //cs4 p7
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,1));
            Console.WriteLine(Add(5 ));
            //Console.WriteLine(Add(1.5, 3.2));
           // Console.WriteLine(Add(9.8, 7));
            //Console.WriteLine(Add(1.2, 3.4, 5.6));
            //Console.ReadLine();
        }
        static Double Add(double x,double y)// 多載:型別不同 或 參數數量不同
        { return x * y; }
        static Double Add(double r )
        { return Math.PI*Math.Pow(r,2) ; }


        //static double Add(double x, double y)
        //{return x + y; }


        //static double Add(double x, double y, double z)
        //{ return x + y + z; }


    }
}
