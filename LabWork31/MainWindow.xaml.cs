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

namespace LabWork31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BirthDateDatePicker.DisplayDateEnd = DateTime.Now;
            PasswordLengthTextBox.Text = $"Длина вашего пароля: {PasswordBox.Password.Length}";
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordLengthTextBox.Text = $"Длина вашего пароля: {PasswordBox.Password.Length}";
        }

        private void BirthDateDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            int age = DateTime.Now.Year - BirthDateDatePicker.SelectedDate.Value.Year;
            if (DateTime.Now.DayOfYear < BirthDateDatePicker.SelectedDate.Value.DayOfYear)
                --age;

            AgeTextBlock.Text = $"Полных лет: {age}";
        }

        private void AboutMeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AboutMeLenghtTextBlock.Text = $"Количество оставшихся символов: {200 - AboutMeTextBox.Text.Length}";
        }

        private void ExperienceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var experience = Math.Ceiling(ExperienceSlider.Value);
            string yearTitle;

            ExperienceTextBox.Text = $"Стаж: {experience} ";
        }
    }
}