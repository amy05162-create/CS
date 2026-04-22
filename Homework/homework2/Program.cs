namespace homework2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for (int num = 1; num < 51; num++)
                //1+2+3....+51的迴圈
            {
                //if (num % 3 != 0 && num % 5 != 0) 
                //如果數字除3的餘數不等於0和如果數字除5的餘數不等於0，加起來
                if (num % 3 == 0 || num % 5 == 0)
                    //如果數字除3的餘數等於0或者如果數字除5的餘數等於0，加起來
                    continue;
                //符合前述條件<-跳過它
                {
                    Console.WriteLine(num);
                    //string s= Enviroment.NewLine;
                    //做其他事情換行
                    //輸出這些數值
                }

            }

        }
    }
}
