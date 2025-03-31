using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Lection0312
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("win buttin");
    }
}