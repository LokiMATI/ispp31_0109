

using Task12;

namespace Task1
{
    public partial class TemplateFillForm : Form
    {
        public TemplateFillForm()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentCreator.CreateDocument(DiscriptionTextBox.Text, int.Parse(TaskCountTextBox.Text));
        }
    }
}
