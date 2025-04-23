namespace QuestSystem
{
    internal interface IQuestFactory
    {
        public IQuest CreateQuest(IQuestConfig questConfig);
    }
}