using System;

namespace Turister.Client.State
{
    public class CounterState
    {
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                OnChange?.Invoke();
            }
        }

        public event Action OnChange;
    }
}