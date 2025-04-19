using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Screen = UnityEngine.Device.Screen;

namespace QuestSystem
{
    [RequireComponent(typeof(Button))]
    internal class AddQuest : MonoBehaviour
    {
        [SerializeField] private QuestView _prefabQuestView;

        [SerializeField] private Transform _questListContentParent;
        [SerializeField] private QuestList _questListConfig;
        
        private Button _button;
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(CreateQuest);
        }
        
        private void CreateQuest()
        { 
            var questView = Instantiate(_prefabQuestView, _questListContentParent);
           var list =  _questListConfig.Quests;
           var randomIndex = UnityEngine.Random.Range(0, list.Count);
           questView.SetText(list[randomIndex].Text);
           var gb = Instantiate(list[randomIndex].Condition, transform.parent);
           gb.GetComponent<RectTransform>().anchoredPosition = GetRandomRectPositionOnScreen();
           var quest = new Quest(questView, gb );
        }

        private Vector2 GetRandomRectPositionOnScreen()
        {
            Vector2 offset = new Vector2(Screen.width / 2f, Screen.height / 2f);
            return new Vector2(Random.Range(50f, Screen.width - 50f), Random.Range(50f, Screen.height - 50f)) - offset;
        }
    }
}