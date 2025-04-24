namespace QuestSystem
{
    internal class QuestFactory : IQuestFactory
    {
        public IQuest Create(IQuestConfig questConfig)
        {
            return new Quest(
                questConfig.Id,
                questConfig.Name,
                questConfig.Description,
                questConfig.Condition,
                new Progress(questConfig.NeededProgress),
                questConfig.Reward
                );
        }
    }
}