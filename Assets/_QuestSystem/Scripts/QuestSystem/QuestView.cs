using TMPro;
using UnityEngine;

namespace QuestSystem
{
    internal class QuestView : MonoBehaviour
    {
        [field : SerializeField] public TMP_Text HeadName { get; private set; }
        [field : SerializeField] public TMP_Text Description { get; private set; }
        [field : SerializeField] public TMP_Text Progress { get; private set; }

        public void SetName(string name) => SetText(HeadName, name);
        public void SetDescription(string description) => SetText(Description, description);
        public void SetProgress(int progress) => SetText(Progress, progress.ToString());
        public void SetProgress(string progress) => SetText(Progress, progress);
        
        private void SetText(TMP_Text tmpText,string text) => tmpText.text = text;
    }
}