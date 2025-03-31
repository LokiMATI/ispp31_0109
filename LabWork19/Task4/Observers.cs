namespace Task4
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject) : base(subject) { }

        public override void Update() 
            => Console.WriteLine($"Binary String: {Convert.ToString(_subject.GetState(), 2)}");
    }

    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject) { }

        public override void Update()
            => Console.WriteLine($"Octal String: {Convert.ToString(_subject.GetState(), 8)}");
    }

    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject) : base(subject) { }

        public override void Update()
            => Console.WriteLine($"Hex String: {Convert.ToString(_subject.GetState(), 16).ToUpper()}");
    }
}