using System;

namespace ShadowsWebsite.Common.StateManagement
{
    public class CounterState
    {
        
            private int counter;

            public int Counter
            {
                get => counter;
                set
                {
                    counter = value;
                    NotifyStateChanged();
                }
            }

            public event Action OnChange;

            private void NotifyStateChanged() => OnChange?.Invoke();

            public void IncrementCount()
            {
                Counter++;
                NotifyStateChanged();
            }

        
    }
}