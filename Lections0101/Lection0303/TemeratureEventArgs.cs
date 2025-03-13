class TemperatureEventArgs
{
    public double OldValue { get; }
    public double NewValue { get; }

    public TemperatureEventArgs(double OldValue, double NewValue)
    {
        OldValue = oldValue;
        NewValue = newValue;
    }

}