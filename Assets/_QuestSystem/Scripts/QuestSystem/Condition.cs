using System;
using UnityEngine;

namespace QuestSystem
{
    internal class KillObjectCondition : MonoBehaviour, ICondition
    {
        public event Action<float> OnCompleted;

        private void OnDisable() => OnCompleted?.Invoke(1f);
    }
}