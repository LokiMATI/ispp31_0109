namespace Task3
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void OpenReplaceFormButton_Click(object sender, EventArgs e)
        {
            ReplaceForm form = new();
            form.ReplaceText = ReplaceText;
            form.ShowDialog();
        }

        private void ReplaceText(string searchText,  string replaceText)
            => InputTextBox.Text = InputTextBox.Text.Replace(searchText, replaceText);
    }
}
