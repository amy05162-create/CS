namespace Farmer_Crossing_the_River_tast
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        private bool _farmerLeft = true;

        private void Cratelist()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","菜"
            };
            _rightList = new List<string>();

        }

        private void selectionMode()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;

        }

        private void ChangData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }


        public Form1()
        {
            InitializeComponent();
            Cratelist();
            selectionMode();
            ChangData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_farmerLeft) return;
            Move(listBox1, _leftList, _rightList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_farmerLeft) return;
            Move(listBox2, _rightList, _leftList);

        }

        private void Move(ListBox box,List<string> from,List<string> to)
        {
            if (box.SelectedItem == null) return;
            string item = (string)box.SelectedItem;
            if(item !="農夫")
            {
                from.Remove("農夫");
                to.Add("農夫");
            }
            from.Remove(item);
            to.Add(item);
            _farmerLeft = !_farmerLeft;

            ChangData();
            CheckGame();
        }

        private void CheckGame()
        {
            CheckSide(_leftList, !_farmerLeft);
            CheckSide(_rightList, _farmerLeft);

            if (_rightList.Count == 4)
            {
                MessageBox.Show("勝利");
            }
        }
        private void CheckSide (List<string> side,bool farmerNotHere)
        {
            if (!farmerNotHere) return;
            if(side.Contains("狼")&& side.Contains("羊"))
            {
                MessageBox.Show("Gameover 狼吃羊");
                
            }
            if (side.Contains("羊") && side.Contains("菜"))
                MessageBox.Show("Gameover 羊吃菜");
        }

    }
}
