using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lection0409.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();

            GroupBox groupBox = new();


            StackPanel mainPanel = new();
            for (int i = 0; i < 10; i++)
            {
                Label label = new()
                {
                    Content = $"{i} text",
                    Foreground = new SolidColorBrush(Colors.Green)
                };
                mainPanel.Children.Add(label);
            }
            groupBox.Content = mainPanel;
            Content = mainPanel;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Page1());
        }
    }
}
