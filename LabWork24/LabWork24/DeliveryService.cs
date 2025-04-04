public class DeliveryService
{
    public const double MinimumTotalForFixedDelivery = 1000;
    public const double MinimumTotalForFreeDelivery = 3000;
    public const double FixedDeliveryCost = 230;
    public const double ExpressDeliveryCostMultiplier = 2;

    public static double CalculateDeliveryCost(Order order)
    {
        double deliveryCost = 0;

        if (order.Total < MinimumTotalForFixedDelivery)
            deliveryCost = order.Total;
        else if (order.Total < MinimumTotalForFreeDelivery)
            deliveryCost = FixedDeliveryCost;

        if (order.IsExpress)
            deliveryCost *= ExpressDeliveryCostMultiplier;

        return deliveryCost;
    }
}