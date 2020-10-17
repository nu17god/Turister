using System;

namespace Turister.Client.State
{
    public class CounterState : IState<int>
    {
        private int _data;
        public event Action OnChange;

        public CounterState()
        {
            _data = PresetData();
        }

        public int Data
        {
            get => _data;
            set
            {
                _data = value;
                OnChange?.Invoke();
            }
        }

        public int PresetData() => 0;
    }
}