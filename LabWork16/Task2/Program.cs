User user = new() { Login = "Test", Password = "qwerty"};

user.PropertyChanged += User_PropertyChanged;

user.Login = "Admin";
user.Password = "Admin";

void User_PropertyChanged(object? sender, EventArgs e)
{
    User user = (User)sender;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {user.Login}");
}