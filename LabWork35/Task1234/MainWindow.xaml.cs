using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1234
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Текстовые файлы|*.txt|Файлы C#|*.cs|HTML-файлы|*.html|CSS-файлы|*.css|JavaScript-файлы|*.js|SQL-файлы|*.sql|Все файлы|*.*";

            if (dialog.ShowDialog() != true)
                return;

            using (StreamReader sr = new(dialog.FileName))
            {
                TextBox.Text = sr.ReadToEnd();
                Title = dialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.Filter = "Текстовые файлы|*.txt|Файлы C#|*.cs|HTML-файлы|*.html|CSS-файлы|*.css|JavaScript-файлы|*.js|SQL-файлы|*.sql|Все файлы|*.*";

            if (dialog.ShowDialog() != true)
                return;

            using (StreamWriter sw = new(dialog.FileName))
            {
                sw.Write(TextBox.Text);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show(
                "Вы хотите закрыть приложение?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}