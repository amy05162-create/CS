namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //使用者寫入一行字串
            int[] numArr = new int[10];
            //新增一個numArr有10個值得陣列0~9
            for(int i=0; i < numArr.Length; i++)
                //在numArr的陣列中迴圈，如果(i<numArr)則遞增。
            {
                foreach (char c in input)
                //從input中提取字元
                {
                    int myNum = int.Parse(c.ToString());
                    //整數myNum轉換成字串
                    if(myNum==i)
                    //如果myNum=i
                    {
                        numArr[i]++;
                        
                    }
                
                    
                }
            
            
            }   
        }
    }
}
