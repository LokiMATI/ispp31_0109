using System.IO;

namespace LabWork39;

public partial class Task1Page : ContentPage
{
    DirectoryInfo _directory = new(@"Y:\ִּÊ.01.01\Images");
    IEnumerable<FileInfo> _files;

    public Task1Page()
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
            .GroupBy(f => f.Extension)
            .Select(e => new 
            { 
                Extension = e.Key, 
                Count = e.Count(), 
                Min = e.Min(m => m.Length), 
                Max = e.Max(m => m.Length),
                Sum = e.Sum(m => m.Length)    
            });

        FilesListView.ItemsSource = files;
    }
}