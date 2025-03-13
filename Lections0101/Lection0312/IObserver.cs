using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public interface IObserver
    {
        Sensor Sensor { get; set; }

        void Update();
    }
}