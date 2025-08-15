using Project.Scripts.Infra;

namespace Project.Scenes.Sample.Scripts.Repository
{
    public class SampleSceneRepository
    {
        public int Id { get; }
        public string Name { get; }
        
        public SampleSceneRepository()
        {
            var testSchema = GameDatabase.MasterDatabase.TestSchemaTable.FindById(1);

            Id = testSchema.Id;
            Name = testSchema.Name;
        }
    }
}
