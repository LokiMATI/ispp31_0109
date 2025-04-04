public class OrderService
{

    private List<Order> orders { get; set; } = [];

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void PrintOrderDetails(int orderId)
    {
        Order? order = GetOrder(orderId);

        if (order == null)
        {
            Console.WriteLine("Заказ не найден.");
            return;
        }

        Console.WriteLine("Идентификатор заказа: " + order.Id);
        Console.WriteLine("Стоимость заказа: " + order.Total);
        Console.WriteLine("Адрес: " + order.Address);
        Console.WriteLine("Экспрес доставка: " + (order.IsExpress ? "Да" : "Нет"));
    }

    private Order? GetOrder(int orderId)
        => orders.FirstOrDefault(o => o.Id == orderId);

    public double CalculateTotalAmount(Order order)
    {
        if (order.Address is null)
            throw new OrderException("Отсутствует адрес доставки.");

        double deliveryCost = DeliveryService.CalculateDeliveryCost(order);

        return order.CalulateFinalOrderCost() + deliveryCost;
    }
}
