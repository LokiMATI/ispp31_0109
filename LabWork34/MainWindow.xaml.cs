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

namespace LabWork34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Save,
                SaveExecuted,
                SaveCanExecuted));
        }

        private void SaveCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = TextBox.Text.Length > 0;
        }

        private async void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog SaveFileDialog = new();
            SaveFileDialog.Filter = "Текстовый формат(*.txt)|*.txt";
            if (!SaveFileDialog.ShowDialog().Value)
                return;

            using (StreamWriter writer = new(SaveFileDialog.FileName))
            {
                await writer.WriteAsync(TextBox.Text);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextLengthStatusBarItem.Content = $"Количество символов: {TextBox.Text.Length}";
        }

        private void ReduceSizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.FontSize > 10)
                SizeSlider.Value -= 10;
        }

        private void IncreaseSizeButton_Click(object sender, RoutedEventArgs e)
        {
            SizeSlider.Value += 10;
        }

        private void StatusBarVisibilityMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            StatusBar.Visibility = StatusBarVisibilityMenuItem.IsChecked ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}