using UnityEngine;

namespace QuestSystem.Conditions
{
    internal class ConditionDestroy : QuestCondition
    {
        private void OnDestroy() => Success?.Invoke();
    }
}