using Project.Scenes.Global.Scripts.Model;
using Project.Scripts.Presenter;
using UnityEngine;

namespace Project.Scenes.Global.Scripts.Presenter
{
    public class GlobalScenePresenter : MonoPresenter
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        protected static void InitializeGameData()
        {
            var sceneModel = new GlobalSceneModel();
#if UNITY_EDITOR
            Debug.Log("Initializes GlobalScenePresenter");
#endif
        }

        protected override void SetupModel() { }

        protected override void SetupView() { }

        protected override void SubscribeView() { }
    }
}
