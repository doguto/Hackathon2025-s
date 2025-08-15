using Project.Scripts.View;
using TMPro;
using UnityEngine;

namespace Project.Scenes.Sample.Scripts.View
{
    public class TestObjectView : MonoView
    {
        [SerializeField] TextMeshProUGUI idText;
        [SerializeField] TextMeshProUGUI nameText;

        public void Setup(int id, string name)
        {
            idText.text = $"ID: {id.ToString()}";
            nameText.text = $"Name: {name}";
        }
    }
}
