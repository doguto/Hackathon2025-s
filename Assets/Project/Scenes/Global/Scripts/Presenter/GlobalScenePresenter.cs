using Project.Scenes.Global.Scripts.Model;
using Project.Scripts.Presenter;
using UnityEngine;

namespace Project.Scenes.Global.Scripts.Presenter
{
    public class GlobalScenePresenter : MonoPresenter
    {
        protected override void Init() { }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        protected static void Initialize()
        {
            var sceneModel = new GlobalSceneModel();
#if UNITY_EDITOR
            Debug.Log("Initializes GlobalScenePresenter");
#endif
        }
    }
}
