using System.Security.Cryptography.X509Certificates;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;

        private void Createlist()
        {
            _list = new List<MyRectangle>();
            _list.Add(new MyRectangle { Name = "D1", Width = 5, Height = 5 });
            _list.Add(new MyRectangle { Name = "D2", Width = 10, Height = 10 });
            _list.Add(new MyRectangle { Name = "D3", Width = 20, Height = 20 });
            _list.Add(new MyRectangle { Name = "D4", Width = 100, Height = 100 });
        }

        public Form1()
        {
            InitializeComponent();
            Createlist();
            SetComboBox();

        }





        private void SetComboBox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            MessageBox.Show($" {item.Name} 的面積為: {item.GetArea()}");

        }
    }
}
