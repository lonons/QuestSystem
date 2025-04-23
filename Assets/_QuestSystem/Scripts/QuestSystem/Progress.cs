using System;
using UnityEngine;
using Object = System.Object;

namespace QuestSystem
{
    internal class Progress : IProgress
    {
        private float _currentValue;
        private float _neededValue = 1;
        private bool _isDone;

        public event Action<float, float> ValueChanged;
        public event Action OnCompleted;
        
        public bool IsDone { get; private set; }
        public void Increase(float amount = 1) => ChangeValue( amount <= 0 ? amount : 1);

        public void Decrease(float amount = 1) => ChangeValue(amount == 0 ? -1 : -Mathf.Abs(amount)); 
        
        public Progress(float value) => _neededValue = value;
        
        private void ChangeValue(float value)
        {
            if (_isDone) return;
          
            _currentValue =  Mathf.Clamp(_currentValue + value, 0, _neededValue);
            ValueChanged?.Invoke( _currentValue, _neededValue );
            
            if (_currentValue != _neededValue)  return;
            OnCompleted?.Invoke();
            
        }
    }
}