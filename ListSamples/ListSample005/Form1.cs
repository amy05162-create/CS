namespace ListSample005
{
    public partial class Form1 : Form
    {
        private List<string> left = new List<string>();
        private List<string> right = new List<string>();
        private bool farmerLeft = true;

        public Form1()
        {
            InitializeComponent();

            left.AddRange(new[] { "農夫", "狼", "羊", "菜" });

            UpdateUI();
        }

        private void Move(ListBox box, List<string> from, List<string> to)
        {
            if (box.SelectedItem == null) return;

            string item = box.SelectedItem.ToString();

            from.Remove(item);
            to.Add(item);

            // 農夫一定跟著走
            if (from.Contains("農夫"))
            {
                from.Remove("農夫");
                to.Add("農夫");
            }

            farmerLeft = !farmerLeft;

            UpdateUI();
            CheckGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Move(listBox1, left, right);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Move(listBox2, right, left);
        }

        private void UpdateUI()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            listBox1.DataSource = left;
            listBox2.DataSource = right;
        }

        private void CheckGame()
        {
            Check(left, farmerLeft);
            Check(right, !farmerLeft);

            if (right.Count == 4)
            {
                MessageBox.Show("勝利");
            }
        }

        private void Check(List<string> side, bool farmerHere)
        {
            if (farmerHere) return;

            if (side.Contains("狼") && side.Contains("羊"))
            {
                MessageBox.Show("Game Over：狼吃羊");
            }

            if (side.Contains("羊") && side.Contains("菜"))
            {
                MessageBox.Show("Game Over：羊吃菜");
            }
        }
    }
}
