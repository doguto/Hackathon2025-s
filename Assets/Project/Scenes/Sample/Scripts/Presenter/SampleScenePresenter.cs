using Project.Scenes.Sample.Scripts.Model;
using Project.Scenes.Sample.Scripts.View;
using Project.Scripts.Presenter;
using UnityEngine;

namespace Project.Scenes.Sample.Scripts.Presenter
{
    public class SampleScenePresenter : MonoPresenter
    {
        [SerializeField] TestObjectView testObjectView;
        
        SampleTestDataModel sampleTestDataModel;
        

        protected override void SetupModel()
        {
            sampleTestDataModel = new SampleTestDataModel();
        }

        protected override void SetupView()
        {
            testObjectView.Init();
        }

        protected override void SubscribeView()
        {
            throw new System.NotImplementedException();
        }
    }
}
