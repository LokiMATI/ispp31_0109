public class Order
{
    private double _total;
    private string _address;

    public const double TotalForDiscount = 10000;
    public const double DiscountPercentage = 0.1;
    public const double Tax = 0.2;   
    public int Id { get; set; }
    public double Total
    {
        get => _total;
        set
        {
            if (value >= 0)
                _total = value;
        }
    }
    public bool IsExpress { get; set; }
    public string Address
    {
        get => _address;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _address = value;
        }
    }

    public double CalulateFinalOrderCost()
        => _total - CalculateOrderDiscount() + Total * Tax;

    private double CalculateOrderDiscount()
        => _total > TotalForDiscount ? _total * DiscountPercentage : 0;
}
