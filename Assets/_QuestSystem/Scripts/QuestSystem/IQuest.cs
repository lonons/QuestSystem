using System;

namespace QuestSystem

{
    internal interface IQuest
    {
        public event Action OnQuestComplete;
        public int GetID { get;  }
        public string GetName { get; }
        public string GetDescription { get; }
    }
}