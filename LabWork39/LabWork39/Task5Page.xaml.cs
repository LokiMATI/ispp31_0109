using System.IO;

namespace LabWork39;

public partial class Task5Page : ContentPage
{
    DirectoryInfo _directory = new(@"Y:\ִּÊ.01.01");
    IEnumerable<FileInfo> _files;
    IEnumerable<DirectoryInfo> _directories;


    public Task5Page()
    {
        InitializeComponent();

        _files = _directory
            .GetFiles("*", SearchOption.AllDirectories)
            .AsEnumerable();
        _directories = _directory
            .GetDirectories("*", SearchOption.AllDirectories)
            .AsEnumerable();

        SetFiles();
    }

    private void SetFiles()
    {
        FilesListView.ItemsSource = _directories.GroupJoin(
            _files,
            d => d.FullName,
            f => f.DirectoryName,
            (d, f) => new
            {
                Name = d.FullName,
                Count = f.Count()
            });
    }
}