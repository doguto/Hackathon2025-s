using UnityEngine;

namespace Project.Scripts.Presenter
{
    public abstract class MonoPresenter : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Init();
            Debug.Log($"Initialized {name}", this);
        }
        
        protected abstract void Init();
    }
}
