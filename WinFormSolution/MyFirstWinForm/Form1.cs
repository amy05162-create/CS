namespace MyFirstWinForm
{
    public partial class Form1 : Form
    //partial 代表部分類別
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Windows Forms");
        }
    }
}
