using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Project.Scripts.View
{
    public class SimpleButton : ButtonBase, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] Image image;
        [SerializeField] float brightNessOnClicked = 0.85f;
        
        Color originalColor;
        
        void Awake()
        {
            originalColor = image.color;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            image.color = originalColor * brightNessOnClicked;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            image.color = originalColor;
        }
    }
}
