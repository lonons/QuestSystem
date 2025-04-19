using System;
using System.Collections.Generic;
using QuestSystem.Conditions;
using UnityEngine;

namespace QuestSystem
{
    [CreateAssetMenu(fileName = "QuestList", menuName = "QuestSystem/QuestList")]
    internal class QuestList : ScriptableObject
    {
        public List<QuestWorkPiece> Quests {get => questList;}
        
        [SerializeField] private List<QuestWorkPiece> questList;
    }

    [Serializable]
    internal struct QuestWorkPiece
    {
        // [field: SerializeField] public Sprite Sprite { get; private set; }
        
        [field: SerializeField]  public string Text { get; private set; }
        [field: SerializeField]  public QuestCondition Condition { get; private set; }
    }

}
