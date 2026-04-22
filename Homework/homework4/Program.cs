namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("請輸入要排序的數字，用,分隔");
            string input = Console.ReadLine();
            string[] numStrs = input.Split(',');

            int[] numArr = new int[numStrs.Length];
            for(int i=0; i< numStrs.Length;i++)

            {
                numArr[i] = int.Parse(numStrs[i]);

            }
            Array.Sort(numArr);

            string result = string.Join(",", numArr);
            //string result = string.Join(Environment.NewLine, numArr);
            Console.WriteLine(result);
            


        }
    }
}
