using Project.Scenes.Global.Scripts.Repository;

namespace Project.Scenes.Global.Scripts.Model
{
    public class GlobalSceneModel
    {
        public GlobalSceneModel()
        {
            var sceneRepository = new GlobalSceneRepository();
        }
    }
}