public class User
{
    private string _login;
    private string _password;

    public string Password
    {
        get => _password;
        set
        {
            _password = value;
            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public string Login
    {
        get => _login;
        set
        {
            _login = value;
            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public event EventHandler PropertyChanged;
}