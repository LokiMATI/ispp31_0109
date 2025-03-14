using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Subject
    {
        private int _state;

        public event Action NotifyObservers;

        public int GetState()
            => _state;

        public void SetState(int state)
        {
            _state = state;
            NotifyObservers?.Invoke();
        }
    }
}