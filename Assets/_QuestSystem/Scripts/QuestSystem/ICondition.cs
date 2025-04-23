using System;
using Unity.VisualScripting;

namespace QuestSystem
{
    internal interface ICondition
    {
        public event Action<float> OnCompleted;
    }
}