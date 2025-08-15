using Project.Scenes.Sample.Scripts.Model;
using Project.Scripts.Presenter;

namespace Project.Scenes.Sample.Scripts.Presenter
{
    public class SampleScenePresenter : MonoPresenter
    {
        protected override void Init()
        {
            var sceneModel = new SampleSceneModel();
        }
    }
}
