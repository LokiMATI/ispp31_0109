User user = new() { Login = "Admin", Password = "qwerty"};
user.PropertyChanged += User_PropertyChanged;

user.Login = "";
user.Password = "123456789012345678901234567890";

user.Login = "Test";

void User_PropertyChanged(object sender, InfoEventArgs e)
{
    User user = sender as User;
    Console.WriteLine($"{e.ChangedDate}: у пользователя {user.Login} изменено {e.NameProperty}.");
    if (e.TextError != string.Empty)
        Console.WriteLine($"Ошибка: { e.TextError}");
}