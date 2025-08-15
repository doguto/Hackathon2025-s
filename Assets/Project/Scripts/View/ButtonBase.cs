using System;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Project.Scripts.View
{
    [DisallowMultipleComponent]
    public abstract class ButtonBase : MonoView, IPointerClickHandler
    {
        protected readonly Subject<Unit> onClicked = new();
        
        public IObservable<Unit> OnClicked => onClicked;
        public bool IsActive { get; private set; } = true;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (!IsActive) return;
            
            onClicked.OnNext(Unit.Default);
        }
    }
}
