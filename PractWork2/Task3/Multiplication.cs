using Excel = Microsoft.Office.Interop.Excel;

namespace Task3
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        private void GenerateMultiplicationTableButton_Click(object sender, EventArgs e)
        {
            GenerateMultiplicationTable();
        }

        private static void GenerateMultiplicationTable()
        {
            var application = new Excel.Application();
            var workbook = application.Workbooks.Add();
            workbook.Worksheets.Add();
            var workSheet = (Excel.Worksheet)workbook.Worksheets[0];
            workSheet.Name = "Умножение";

            for (int i = 2; i < 10; i++)
                workSheet.Cells[1, i] = i;

            for (int i = 2; i < 10; i++)
                workSheet.Cells[i, 1] = i;

            for (int i = 2; i < 10; i++)
                for (int j = 2; j < 10; j++)
                    workSheet.Cells[i, j] = i * j;


            var renge = workSheet.Range[workSheet.Cells[2, 2], workSheet.Cells[9, 9]].Cut();

            workbook.SaveAs("Таблица умножения.xlsx");
            application.Quit();
        }
    }
}
