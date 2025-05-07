// Исходный код приложения для рефакторинга
OrderService orderService = new();

var order = new Order { Total = 1200, IsExpress = true, Address = "Папанина, 24" };
orderService.AddOrder(order);

orderService.PrintOrderDetails(order.Id);

Console.WriteLine("Полная стоимость: " + orderService.CalculateFinalPrice(order));

// заказ
public class Order
{
    public int Id { get; set; }
    public double Total;
    public bool IsExpress { get; set; }
    public string Address;
}

// Сервис для работы с заказами
public class OrderService
{
    private List<Order> orders { get; set; } = [];

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void PrintOrderDetails(int orderId)
    {
        var order = orders.FirstOrDefault(o => o.Id == orderId);

        if (order == null)
        {
            Console.WriteLine("Order not found.");
            return;
        }
        else
        {
            Console.WriteLine("Order Id: " + order.Id);
            Console.WriteLine("Стоимость заказа: " + order.Total);
            Console.WriteLine("Адрес: " + order.Address);
            Console.WriteLine("Экспрес доставка: " + (order.IsExpress ? "Yes" : "No"));
        }
    }

    public double CalculateFinalPrice(Order order)
    {
        double t = 0.2; // НДС            

        // Расчет скидки
        double discount = 0;
        if (order.Total > 10000) // скидка 10% при заказе от 10000
        {
            discount = order.Total * 0.1;
        }
        else
        {
            discount = 0;
        }

        // Расчет стоимости доставки
        double delCost = 0; // Доставка бесплатная, если заказ дороже 3000 рублей
        if (order.Total < 1000)
        {
            delCost = order.Total;
        }
        else if (order.Total >= 1000 && order.Total < 3000)
        {
            delCost = 230;
        }
        if (order.IsExpress)
            delCost *= 2;
        if (order.Address is null)
            return -1;

        return order.Total - discount + (order.Total * t) + delCost;
    }
}
