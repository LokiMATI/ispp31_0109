public class PowerfullRandom : Random
{
    public double NextDouble(double min,  double max)
    {
        return NextDouble() * (max - min) + min;
    }
}
