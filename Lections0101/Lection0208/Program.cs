Console.WriteLine("generics");

//Print(123);
//Print("123");
//Print(123.00);

//static void Print<T>(T item)
//{
//    Console.WriteLine($"{item} - {item?.GetType()}");
//}

int a = 5, b = 6;

string s = "5";

Swap(ref a, ref b);

//Console.WriteLine($"a: {a}, b: {b}");

static void Swap<T>(ref T item1, ref T item2)
    => (item1, item2) = (item2, item1);

static T GetMin<T>(T x, T y)
    where T : IComparable, IComparable<T>
    => x.CompareTo(y) < 0 ? x : y;

List<string> users = ["admin", "user", "student"];

users.Add("admin123");
users.AddRange(users);

users.Insert(0, "guees1");
users.InsertRange(2, ["hue", "sdw"]);



foreach (var user in users)
    Console.WriteLine(user);