namespace Task4
{
    public partial class NumberForm : Form
    {
        public NumberForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            numberTextBox.Text = button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = string.Empty;
        }
    }
}
