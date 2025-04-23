using System;

namespace QuestSystem
{
    internal interface IProgress 
    {
        public event Action<float, float> ValueChanged;
        public event Action OnCompleted;
        public bool IsDone { get; }

        public void Increase(float amount);
        public void Decrease(float amount);
            
    }
}