using System;

namespace QuestSystem
{
    internal interface IQuestConfig
    {
        public int Id {get;}
        public string Name { get; }
        public string Description { get; }
        public float NeededProgress { get; }
        public ICondition Condition { get; }
        public IReward Reward { get; }
        
    }
}