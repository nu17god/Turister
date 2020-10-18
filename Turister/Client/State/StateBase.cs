using System;

namespace Turister.Client.State
{
    public abstract class StateBase<T>
    {
        private T _data;
        public event Action OnChange;

        public T Data
        {
            get => _data;
            set
            {
                _data = value;
                OnChange?.Invoke();
            }
        }

        public StateBase()
        {
            _data = PresetData();
        }

        protected abstract T PresetData();
    }
}