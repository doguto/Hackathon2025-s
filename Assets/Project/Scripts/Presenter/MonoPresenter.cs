using UniRx;
using UnityEngine;

namespace Project.Scripts.Presenter
{
    public abstract class MonoPresenter : MonoBehaviour
    {
        protected virtual void Awake()
        {
            SetupModel();
            SetupView();
            SubscribeView();
            
#if UNITY_EDITOR
            Debug.Log($"Initialized {name}", this);
#endif
        }

        protected abstract void SetupModel();
        protected abstract void SetupView();
        protected abstract void SubscribeView();
    }
}
