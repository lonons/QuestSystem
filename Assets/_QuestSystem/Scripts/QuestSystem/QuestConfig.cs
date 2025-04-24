using System;
using UnityEngine;

namespace QuestSystem
{
    [CreateAssetMenu(fileName = "QuestConfig", menuName = "QuestSystem/QuestConfig")]
    internal class QuestConfig : ScriptableObject, IQuestConfig
    {
        public int Id { get; private set; }
        [field : SerializeField] public string Name { get; private set; }
        [field : SerializeField] public string Description { get; private set; }
        [field : SerializeField] public float NeededProgress { get; private set; }
        [field : SerializeField]  public ICondition Condition { get; private set; }
        [field : SerializeField]  public IReward Reward { get; private set; }
    }
}