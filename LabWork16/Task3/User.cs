using System.Runtime.CompilerServices;

public class User
{
    private string _login;
    private string _password;

    public string Password
    {
        get => _password;
        set
        {
            if (value.Length >= 6 && value.Length <= 20 && _password != value)
            {
                _password = value;
                OnPropertyChange();
                return;
            }

            OnPropertyChange("Пароль должен быть не меньше 6 и не больше 20 символов.");
        }
    }

    public string Login
    {
        get => _login;
        set
        {
            if (_login != value && value != "")
            {
                _login = value;
                OnPropertyChange();
                return;
            }

            OnPropertyChange("Логин не должен быть пустым.");
        }
    }

    public event EventHandler<InfoEventArgs> PropertyChanged;

    private void OnPropertyChange(string textError = "", [CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new InfoEventArgs(propertyName, textError));
    }
}