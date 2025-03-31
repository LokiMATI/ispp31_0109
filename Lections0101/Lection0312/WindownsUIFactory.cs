using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Lection0312
{
    public class WindownsUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
    }
}