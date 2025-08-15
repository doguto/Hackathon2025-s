using Project.Scenes.Sample.Scripts.Model;
using Project.Scenes.Sample.Scripts.View;
using Project.Scripts.Presenter;
using UnityEngine;

namespace Project.Scenes.Sample.Scripts.Presenter
{
    public class SampleScenePresenter : MonoPresenter
    {
        [SerializeField] TestObjectView testObjectView;

        protected override void Init()
        {
            var sceneModel = new SampleSceneModel();

            testObjectView.Init();
            testObjectView.Setup(sceneModel.Id, sceneModel.Name);
        }
    }
}
