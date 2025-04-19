using TMPro;
using UnityEngine;

namespace QuestSystem
{
    internal class QuestView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tmpText;

        public void SetText(string text)
        {
            if (_tmpText  != null)  _tmpText.text = text;
            else Debug.LogError(gameObject.name + " has not been assigned");
        }
        
        public void Destroy() => GameObject.Destroy(gameObject);
    }
}
