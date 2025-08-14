using Project.Scenes.Global.Scripts.Model;
using Project.Scripts.Presenter;

namespace Project.Scenes.Global.Scripts.Presenter
{
    public class GlobalScenePresenter : MonoPresenter
    {
        protected override void Init()
        {
            var sceneModel = new GlobalSceneModel();
        }
    }
}
