namespace MethodSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, -2, 3, -4, 5, 6 };
            int[] numbers2 = { 10, 20, -30, 40, -50 };
            int sumOfPositives1 = CalculatsSumOfPositives(numbers1);
            Console.WriteLine($"number1中的正數總和:{sumOfPositives1}");
            ////處理number2
            //int sumOfPositives2 = 0;
            //foreach (int num in numbers2)
            //{
            //    if (num > 0)
            //    {
            //        sumOfPositives2 += num;
            //    }

            //}
            int sumOfPositives2 = CalculatsSumOfPositives(numbers2);
            Console.WriteLine($"number2中的正數總和:{sumOfPositives2}");
        }

        private static int CalculatsSumOfPositives(int[] numbers)
        {
            int sumOfPositives = 0;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    sumOfPositives += num;
                }

            }

            return sumOfPositives;
        }
    }
}
