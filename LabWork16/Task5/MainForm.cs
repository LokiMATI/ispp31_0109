namespace Task5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChangeFormButton_Click(object sender, EventArgs e)
        {
            ChangeForm form = new();
            form.ChangeText += ChangeText;
            form.ShowDialog();
        }

        private void ChangeText(string searchText, string newText) 
        {
            InputTextBox.Text = InputTextBox.Text.Replace(searchText, newText);
        }
    }
}
