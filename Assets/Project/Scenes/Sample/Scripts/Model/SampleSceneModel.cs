using Project.Scenes.Sample.Scripts.Repository;

namespace Project.Scenes.Sample.Scripts.Model
{
    public class SampleSceneModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        
        public SampleSceneModel()
        {
            var sceneRepository = new SampleSceneRepository();

            Id = sceneRepository.Id;
            Name = sceneRepository.Name;
        }
    }
}
