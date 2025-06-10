using System.IO;
using System.Linq;

namespace LabWork39;

public partial class Task3Page : ContentPage
{
    DirectoryInfo _directory = new(@"Y:\ִּÊ.01.01");
    DirectoryInfo[] _directories;
    IEnumerable<FileInfo> _files;

    public Task3Page()
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
        var files = _files.Select(f => new { f.Name, f.Directory, f.CreationTime });
        var directories = _directories.Select(d => new { d.Name, Directory = d.Parent, d.CreationTime });

        FilesListView.ItemsSource = files.Union(directories);
    }
}