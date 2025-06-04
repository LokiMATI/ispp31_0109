namespace LabWork39;

public partial class Task4Page : ContentPage
{
    DirectoryInfo _directory = new(@"C:\temp\ispp31\MatigorovNikita\LabWork39\LabWork39");
    DirectoryInfo[] _directories;
    IEnumerable<FileInfo> _files;

    public Task4Page()
    {
        InitializeComponent();

        _directories = _directory.GetDirectories();
        _files = _directory
            .GetFiles("*", SearchOption.AllDirectories)
            .AsEnumerable();

        SetFiles();
    }

    private void SetFiles()
    {
        var files = _directories
            .Where(d => d.CreationTime.Date == DateTime.Today)
            .Join(_files, d => d.FullName, f => f.DirectoryName, (d, f) => new { f.Name, Directory = d.FullName });

        FilesListView.ItemsSource = files;
    }
}