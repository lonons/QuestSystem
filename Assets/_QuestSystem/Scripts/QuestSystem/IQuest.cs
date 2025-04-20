namespace QuestSystem
{
    internal interface IQuest
    {
        public int GetID { get;  }
        public string GetName { get; }
        public string GetDescription { get; }
    }
}