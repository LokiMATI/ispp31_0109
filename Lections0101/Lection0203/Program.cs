Console.WriteLine("interface");

//Car car = new() { Brand = "bmw" };

//class Car : IEquatable<Car>
//{
//    public string Brand { get; set; }
//    public int Speed { get; set; }

//    public bool Equals(Car? other)
//        => Brand == other?.Brand && Speed == other?.Speed;
//}

Car car = new() { Brand = "bmw" };
Car[] cars = [
        new() {Brand = "bmw", Speed = 120},
        new() {Brand = "lada", Speed = 60},
        new() {Brand = "toyota", Speed = 200},
   ];

foreach (var car in cars)
    Console.WriteLine(car);

Console.WriteLine();

Array.Sort(cars);
foreach (var car in cars)
    Console.WriteLine(car);
class Car1 : IEquatable<Car>
{
    public string Brend { get; set; }
    public int Speed  { get; set; }

    public bool Equals(Car? other) 
        => Brend == other?.Brand && Speed == other?.Speed;
}
class Car : IComparable //CompareTo/Compare
{
    public string Brand { set; get; }
    public int Speed { get; set; }

    //public int CompareTo(object? obj)
    //{
    //    if (obj is Car car)
    //        return Speed.CompareTo(car.Speed);
    //    throw new ArgumentException();
    //    //var car = obj as Car;
    //    //return Speed.CompareTo(car?.Speed);
    //    /*if (Speed > car.Speed)
    //        return 1;
    //    if (Speed < car.Speed ) 
    //        return -1;
    //    return 0;*/
    //}
    public override string ToString()
    {
        return $"{Brand}, {Speed} км/ч";
    }

    int IComparable.CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
