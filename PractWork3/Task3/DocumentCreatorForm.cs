namespace Task3
{
    public partial class DocumentCreatorForm : Form
    {
        public DocumentCreatorForm()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            DocumentCreator.CreateDocument(DescriptionTextBox.Text);
        }

    }
}
