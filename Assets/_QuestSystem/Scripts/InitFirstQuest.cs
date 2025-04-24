using System;
using QuestSystem;
using UnityEngine;

namespace _QuestSystem.Scripts
{
    internal class InitFirstQuest : MonoBehaviour
    {
        private IQuestManager _questManager = new QuestManager();
        [SerializeField] private QuestConfig _mainQuest;
        
        private void Start()
        {
            _questManager.Add(_mainQuest);
        }
    }
}