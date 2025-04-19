using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace  QuestSystem
{
    [RequireComponent(typeof(Image))]
    internal class Yabloko : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        [SerializeField] private Sprite _appleOpened;
        [SerializeField] private Sprite _appleClosed;

        private Image _image;
        private void Awake()
        {
            _image = GetComponent<Image>();
        }
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            _image.sprite = _appleClosed; ;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _image.sprite = _appleOpened;
        }


        public void OnPointerClick(PointerEventData eventData) =>  Destroy(gameObject);
    }

}
