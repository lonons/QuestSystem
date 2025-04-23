namespace QuestSystem
{
    internal class QuestFactory : IQuestFactory
    {
        
        public IQuest CreateQuest(IQuestConfig questConfig)
        {
            return new Quest(
                0,
                questConfig.Name,
                questConfig.Description,
                new KillObjectCondition(),
                new Progress(questConfig.NeededProgress),
                new Reward()
                );
        }
    }
}