namespace QuestSystem
{
    internal interface IQuestConfig
    {
        public string Name { get; }
        public string Description { get; }
        public float NeededProgress { get; }
        
    }
}