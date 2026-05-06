using System;
using System.Collections.Generic;
using System.Text;

namespace DictionarySample001
//存取修飾詞:internal內部的(專案內部)，public公開(哪裡都可以用)，private(私人的類別內可以使用)
//欄位只能存入資料，屬性是可以存取資料。
{
    internal class MyRectangle//內部的(專案內部)類別命名為我的正方形
    {
        public int Width { get; set; }
        //屬性:(可以存取的資料):公開的整數寬度值存取空間， 
        public int Heigth { get; set; }
        //屬性:(可以存取的資料):公開的整數高度值存取空間 
        public int GetArea()
            //方法:公開的 整數 ''得到面積''可以被呼叫
    {
            return Width * Heigth;
            //方法會回傳寬*高的值
    }

    }
}
