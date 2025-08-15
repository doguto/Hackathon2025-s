using Project.Scenes.Sample.Scripts.Repository;

namespace Project.Scenes.Sample.Scripts.Model
{
    public class SampleTestDataModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        
        public SampleTestDataModel()
        {
            var testDataRepository = new SampleTestDataRepository();

            Id = testDataRepository.Id;
            Name = testDataRepository.Name;
        }
    }
}
