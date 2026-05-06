using System.Drawing.Text;

namespace DictionarySample001
{
    public partial class Form1 : Form //Form1 : Form 代表這個類別的名稱是 Form1 ，他的父類別是 Form (也就是繼承自 Form Class)

    {
        private Dictionary<string, MyRectangle> _dictionary;//欄位:私人 字典<索引:字串, 值:MyRectangle> 存入 _dictionary; 裡。

        private void CreateDictionary()//方法:私人的沒有回傳值的CreateDictionar()<--可以被呼叫
        {
            _dictionary = new Dictionary<string, MyRectangle>();//_dictionary =新的 字典<索引, 值MyRectangle>
            _dictionary.Add("D1", new MyRectangle { Width = 5, Heigth = 5 });//把資料加進_dictionary查詢表中，用「D1」這個名字來存資料， 建立一個新的 MyRectangle，並設定 Width = 5、Height = 5(初始化物件語法:new MyRectangle { Width = 5, Heigth = 5 },建立物件幫他設定屬性)
            _dictionary.Add("D2", new MyRectangle { Width = 10, Heigth = 10 });//.Add是dictionary裡面的方法喔(系統內建的)
            _dictionary.Add("D3", new MyRectangle { Width = 20, Heigth = 20 });
            _dictionary.Add("D4", new MyRectangle { Width = 100, Heigth = 100 });


        }

        public Form1()
        {
            InitializeComponent();//呼叫初始化成分
            CreateDictionary();//呼叫CreateDictionar();方法


        }

        private void button1_Click(object sender, EventArgs e)//觸發私人的沒有回傳值的按鈕(物件 
        {
            string key = textBox1.Text;//字串key = 輸入框.
            //if(_dictionary.ContainsKey(key))
            //{
            //    int area = _dictionary[key].GetArea();
            //    MessageBox.Show($"{key}的面積為:{area}");


            //}
            //else
            //{
            //    MessageBox.Show("查無資料");
            if (_dictionary.TryGetValue(key, out MyRectangle rect))//(如果字典裡有key的話就把 把相應的MyRectangle存入rect)
            {
                int area = rect.GetArea();//int area面積 =用GetArea做起來這個矩型
                MessageBox.Show($"{key} 的面積為: {area}");//跳出一訊息框"{key}的面積是area
            }

            else
            {
                MessageBox.Show("查無資料");//查不到資料
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }





}
