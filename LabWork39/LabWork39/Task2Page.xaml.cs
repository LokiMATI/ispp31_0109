namespace LabWork39;

public partial class Task2Page : ContentPage
{
    DirectoryInfo _directory = new DirectoryInfo(@"Y:\ִּÊ.01.01");
    IEnumerable<FileInfo> _files;

    public Task2Page()
    {
        InitializeComponent();

        _files = _directory
            .GetFiles("*", SearchOption.AllDirectories)
            .AsEnumerable();

        SetFiles();
    }

    private void SetFiles()
    {
        var files = _files
            .GroupBy(f => new {f.CreationTime.Month, f.CreationTime.Year})
            .Select(f => new { f.Key.Year, f.Key.Month, Count = f.Count() });

        FilesListView.ItemsSource = files;
    }
}