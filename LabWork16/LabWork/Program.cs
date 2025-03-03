using System.ComponentModel;

User user = new() { Login = "Test", Password = "qwerty" };
user.PropertyChanged += User_PropertyChanged;

void User_PropertyChanged(object sender, PropertyChangedEventArgs e)
    => Console.WriteLine($"Был изменен параметр {e.PropertyName}");