namespace QuestSystem
{
    internal interface IQuestFactory
    {
        public IQuest Create(IQuestConfig questConfig);
    }
}