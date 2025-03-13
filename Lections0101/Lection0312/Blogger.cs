using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class Blogger
    {
        public event Action<string> VideoPublished;

        public void PublishVideo(string title)
        {
            Console.WriteLine($"Новое видео {title}");
            VideoPublished?.Invoke(title);
        }
    }
}