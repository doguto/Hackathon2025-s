using Project.Scripts.Model;

namespace Project.Scenes.Sample.Scripts.Model
{
    public class SampleTestDataModel : ModelBase
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        
        public SampleTestDataModel()
        {
            var testSchema = masterDataRepository.Database.TestSchemaTable.FindById(1);
            
            Id = testSchema.Id;
            Name = testSchema.Name;
        }
    }
}
