using System;
using Project.Scripts.View;
using UniRx;
using UnityEngine;

namespace Project.Scenes.Sample.Scripts.View
{
    public class SampleSceneView : MonoView
    {
        [SerializeField] SimpleButton button;

        public IObservable<Unit> OnLoadTestData => button.OnClicked;
    }
}
