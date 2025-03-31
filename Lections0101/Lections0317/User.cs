public class User // Model
{
    public int Id { get; set; }
    public string Login { get; set; }
}

class UserView // View
{
    public void UpdateLogin(string login)
        => Console.WriteLine($"login: {login}");
}

class UserController // Controller
{
    private User _model;
    private UserView _view;

    public UserController(User model, UserView view)
    {
        _model = model;
        _view = view;
    }

    public string UserLogin 
    {  
        get => _model.Login; 
        set => _model.Login = value; 
    }

    public void UpdateView() 
        => _view.UpdateLogin(UserLogin);
}