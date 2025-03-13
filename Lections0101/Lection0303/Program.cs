using System.ComponentModel;

Console.WriteLine("events");

Sensor sensor1 = new() { Temperature = -2, Pressere = 750 };
sensor1.PropertyChanged += Sensor_PropertyChanged;
sensor1.Temperature = 0;
sensor1.Temperature = 5;
sensor1.Pressere = 755;

Sensor sensor2 = new() { Temperature = 10, Pressere = 750 };
sensor2.PropertyChanged += Sensor_PropertyChanged;
sensor1.Temperature = 20;

void Sensor_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Sensor sensor = (Sensor)sender;
    Console.WriteLine($"изменилось значение {e.PropertyName}");
    Console.WriteLine($"t={sensor.Temperature}, p={sensor.Pressere}");
    Console.WriteLine();
}