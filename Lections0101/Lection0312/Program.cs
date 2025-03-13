using Lection0312;
Console.WriteLine("patters");
/*
Logger.GetInstance().Log("LOG: test singleon");
Logger.GetInstance().Log($"LOG: {DateTime.Now}");

Application application = new();
var pdf = application.Create("pdf");

IUIFactory factory = new WindownsUIFactory();
IButton button = factory.CreateButton();
button.Render();


QueryBuilder builder = new("users");
builder = builder
    .Where("age > 18")
    .Select("name, age")
    .OrderBy("name")
    .OrderBy("age");

Console.WriteLine(builder.Build());

var paymentProccessor = new PaymentProccessor();
paymentProccessor.ChangeStrategy(new CardPayment());

paymentProccessor.ProccessPayment(123);


Blogger kuplinov = new();
kuplinov.PublishVideo("first");

Subscrider panov = new();
kuplinov.VideoPublished += panov.OnVideoPublished;

Subscrider panov2 = new();

kuplinov.VideoPublished += panov2.OnVideoPublished;

kuplinov.PublishVideo("Second");

Sensor sensor = new();

sensor.AddObserver(new TemperatureDisplay() { Sensor = sensor });
sensor.AddObserver(new PressureDispaly() { Sensor = sensor });

sensor.Temperature = -5;
sensor.Pressure = 750;
sensor.NotifyObservers();

IService service = new DataService();
service.Execute();

service = new LoggingDecorator(service);

service.Execute();
*/

IPizza pizza = new BasePizza();

Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()} руб");
pizza = new Cheese(pizza);
pizza = new Cheese(pizza);
pizza = new Tomato(pizza);
pizza = new Pepperoni(pizza);
pizza = new Pepperoni(pizza);

Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()} руб");