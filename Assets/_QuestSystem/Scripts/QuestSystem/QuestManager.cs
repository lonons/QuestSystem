using System.Collections.Generic;

namespace QuestSystem
{
    internal class QuestManager : IQuestManager
    {
        private IQuestFactory _questFactory = new QuestFactory();
        private List<Quest> _quests;
        
        public void Add(IQuestConfig questConfig)
        {
            var quest = _questFactory.Create(questConfig);
        }
    }

    internal interface IQuestManager
    {
        public void Add(IQuestConfig questConfig);
    }
}