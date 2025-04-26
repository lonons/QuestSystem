namespace QuestSystem
{
    internal class ConditionsEventBus
    {
        private static ConditionsEventBus instance;
        
        public static ConditionsEventBus Instance()
        {
            return instance ?? (instance = new ConditionsEventBus());
        }

        public void Add()
        {
            
        }

        public void Get()
        {
            
        }
    }
}