using QuestSystem.Conditions;

namespace QuestSystem
{
    internal class Quest
    {
        private QuestView _questView;
        private QuestCondition _questCondition;
        public Quest(QuestView questView, QuestCondition questCondition)
        {
            _questView = questView;
            _questCondition = questCondition;
            _questCondition.Success += Finished;
        }

        private void Finished()
        {
            _questCondition.Success -= Finished;
            _questView.Destroy();
        }
    }
}
