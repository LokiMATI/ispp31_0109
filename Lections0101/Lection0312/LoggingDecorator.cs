using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class LoggingDecorator : IService
    {
        private readonly IService _service;

        public LoggingDecorator(IService service)
            => _service = service;

        public void Execute()
        {
            Console.WriteLine("LOG: proccess start");
            _service.Execute();
            Console.WriteLine("LOG: proccess finish");
        }
    }
}