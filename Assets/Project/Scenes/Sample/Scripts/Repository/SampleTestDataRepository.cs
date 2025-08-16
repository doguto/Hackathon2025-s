using Project.Scripts.Infra;

namespace Project.Scenes.Sample.Scripts.Repository
{
    public class SampleTestDataRepository
    {
        public int Id { get; }
        public string Name { get; }
        
        public SampleTestDataRepository()
        {
            var testSchema = GameDatabase.MasterDatabase.TestSchemaTable.FindById(1);

            Id = testSchema.Id;
            Name = testSchema.Name;
        }
    }
}
