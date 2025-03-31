using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Lection0312
{
    public class Subscrider
    {
        public void OnVideoPublished(string title)
            => Console.WriteLine($"Смотри {title}");
    }
}