using System;
using UnityEngine;

namespace QuestSystem
{
    internal class Quest : IQuest
    {
        public event Action OnQuestComplete;
        public int GetID {get; private set;}
        public string GetName {get; private set;}
        public string GetDescription {get; private set;}


        private IProgress _progress;
        private ICondition _condition;
        private IReward _reward;

        public Quest(int id, string name , string description, ICondition condition,  IProgress progress, IReward reward)
        {
            GetID = id;
            GetName = name;
            GetDescription = description;
            _progress = progress;
            _condition = condition;
            _reward = reward;
            
            _condition.OnCompleted += _progress.Increase;
            _progress.OnCompleted += QuestCompleted;
        }
        
        private void QuestCompleted()
        {
            _reward.GiveReward();
            _condition.OnCompleted -= _progress.Increase;
            _progress.OnCompleted -= QuestCompleted;
        }
    }
}