namespace Lection0227_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.FormAction = ChangeText;
            form.ShowDialog();
        }

        private void ChangeText(string text)
        {
            label1.Text = text;
        }
    }
}
