using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class PressureDispaly : IObserver
    {
        public Sensor Sensor { get; set; }
        public void Update() 
            => Console.WriteLine($"p={Sensor.Pressure}");
    }
}