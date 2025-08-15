using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Project.Scripts.View
{
    public class SimpleButton : ButtonBase, IPointerDownHandler, IPointerUpHandler
    {
        // Click時に暗くしたいImage
        [SerializeField] Image image;
        [SerializeField] float brightnessOnClicked = 0.85f;
        
        Color originalColor;
        
        void Awake()
        {
            image ??= GetComponent<Image>();
            if (image == null)
            {
                Debug.LogError("Image not found", this);
                return;
            }
            
            originalColor = image.color;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            image.color = originalColor * brightnessOnClicked;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            image.color = originalColor;
        }
    }
}
