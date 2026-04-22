namespace MethodSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, -2, 3, -4, 5, 6 };
            int[] numbers2 = { 10, 20, -30, 40, 50, 60 };

            int CalculatSumOfPositives1 = CalculatSumOfPositives(numbers1);
            Console.WriteLine($"number1中的正數總和{CalculatSumOfPositives1}");
            int CalculatSumOfPositives2 = CalculatSumOfPositives(numbers2);
            Console.WriteLine($"number1中的正數總和{CalculatSumOfPositives2}");

        }

        static int CalculatSumOfPositives(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num > 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
