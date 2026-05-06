using System.ComponentModel.DataAnnotations;

namespace LinqSample016
{
    internal class Program
    {
        //p130
        static void Main(string[] args)
        {
            
            var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultOfSkip = list.Skip(3);
            Console.WriteLine("Skip(3)的結果");
            Display(resultOfSkip);

            var resultOfTake = list.Take(3);
            Console.WriteLine("Take(3)的結果");
            Display(resultOfTake);

            var resultOfSkipTake = list.Skip(2).Take(2);
            Console.WriteLine("Skip(2).Take(2)的結果");
            Display(resultOfSkipTake);

            Console.ReadLine();
        }

        static void Display(IEnumerable<string> source) 
           
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
        //IEnumerable 是靜態類別(所有成員都是靜態)
        //大部分靜態方法是擴充方法
        //靜態方法和執行個體成員的差異
        //靜態方法透過型別呼叫
        //執行個體成員方法透過執行個體成員呼叫
        //擴充方法可以讓靜態方法假裝成執行個體方法
        //假裝成第一個參數的執行個體方法
        //延遲執行:linq，立即執行"TO類別"
        //Where->TOlist 先找資料在傳清單(正確做法)
        //TOlist->WHere 先傳清單在找資料(會大當機)

    }
}
