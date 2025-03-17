Console.WriteLine("MV(x)");

User user = GetUserById(123);

UserView view = new();

UserController controller = new(user, view);
controller.UpdateView();
controller.UserLogin = "adm";
controller.UpdateView();

static User GetUserById(int id)
    => new() { Id = id, Login = "admin" };