using TMPro;
using UnityEngine;

namespace QuestSystem
{
    internal class QuestView : MonoBehaviour
    {
        [field : SerializeField] public TMP_Text HeadName { get; private set; }
        [field : SerializeField] public TMP_Text Description { get; private set; }
        [field : SerializeField] public TMP_Text Progress { get; private set; }
    }
}