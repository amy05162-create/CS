namespace ValueTupleReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var width = 10;
            //var height = 15;
            var (w, h) = (10, 15);

            Console.WriteLine(Calculator(w, h));
        }

        static (double area,double perimeter)Calculator(double width,double height)
        {
            double area = width * height;
            double perimeter = (height + width) * 2;
            return (area, perimeter);

        }
    }
}
