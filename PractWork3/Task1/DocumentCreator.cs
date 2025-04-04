using Word = Microsoft.Office.Interop.Word;

namespace Task12
{
    internal class DocumentCreator
    {
        public static void CreateDocument(string replaceText, int taskCount)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;

            var document = wordApp.Documents.Add(Environment.CurrentDirectory + "\\Шаблон.docx");
            document.Content.Find.Execute(FindText: "ТекстИзПоляВвода", ReplaceWith: replaceText,
                Replace: Word.WdReplace.wdReplaceOne);

            var table = document.Tables[1];

            if (taskCount > 0)
            {
                table.Cell(2, 1).Range.Text = 1.ToString();

                for (int i = 3; i <= taskCount + 1; i++)
                {
                    table.Rows.Add();
                    table.Cell(i, 1).Range.Text = (i - 1).ToString();
                }
            }
            else
            {
                table.Rows[2].Delete();
            }

            document.Content.Find.Execute(FindText: "дд.мм.гггг чч:мм", ReplaceWith: DateTime.Now,
                Replace: Word.WdReplace.wdReplaceOne);

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
