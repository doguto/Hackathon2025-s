using UnityEngine;

namespace Project.Scripts.Presenter
{
    public abstract class MonoPresenter : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Init();

#if UNITY_EDITOR
            Debug.Log($"Initialized {name}", this);
#endif
        }
        
        protected abstract void Init();
    }
}
