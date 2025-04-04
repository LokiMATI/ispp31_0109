OrderService orderService = new();

var order = new Order { Total = 1200, IsExpress = true, Address = "Папанина, 24" };
orderService.AddOrder(order);

orderService.PrintOrderDetails(order.Id);

Console.WriteLine("Полная стоимость: " + orderService.CalculateTotalAmount(order));
