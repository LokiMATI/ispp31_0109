namespace LabWork39
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenTask1PageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Task1Page());
        }

        private void OpenTask2PageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Task2Page());
        }

        private void OpenTask3PageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Task3Page());
        }

        private void OpenTask4PageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Task4Page());
        }

        private void OpenTask5PageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Task5Page());
        }
    }

}
