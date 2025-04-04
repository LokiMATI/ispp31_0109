using Word = Microsoft.Office.Interop.Word;

namespace Task3
{
    internal class DocumentCreator
    {
        public static void CreateDocument(string text)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;

            var document = wordApp.Documents.Add();

            document.Content.Text = text;

            document.Content.Font.Size = 14;
            document.Content.Font.Name = "Times New Roman";

            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "docx|*.docx|pdf|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    document.SaveAs2(saveFileDialog.FileName);
                }
                else
                {
                    document.SaveAs2(saveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                }
            }

            wordApp.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
        }
    }
}
