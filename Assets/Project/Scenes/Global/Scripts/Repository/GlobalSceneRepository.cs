using Project.Scripts.Infra;

namespace Project.Scenes.Global.Scripts.Repository
{
    public class GlobalSceneRepository
    {
        public GlobalSceneRepository()
        {
            new GameDatabaseLauncher().Launch();
        }
    }
}
