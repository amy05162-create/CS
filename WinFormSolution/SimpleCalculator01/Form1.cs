using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //int x = int.Parse(textBox1.Text);
            //int y = int.Parse(textBox2.Text);
            //label1.Text = (x + y).ToString();

            //CalculateAndShow("-");

            DisplayResult(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int x = int.Parse(textBox1.Text);
            //int y = int.Parse(textBox2.Text);
            //label1.Text = (x + y).ToString();

            //CalculateAndShow("+");

            DisplayResult(false);

        }

        //private void CalculateAndShow(string op)
        //{
        //    int x = int.Parse(textBox1.Text);
        //    int y = int.Parse(textBox2.Text);

        //    if (op == "+") label1.Text = (x + y).ToString();
        //    if (op == "-") label1.Text = (x - y).ToString();

        //}

        private void DisplayResult(bool isAdd)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (isAdd)
            {
                label1.Text = (x + y).ToString();
                return;

            }
            label1.Text = (x - y).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
