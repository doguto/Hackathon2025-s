using Project.Scripts.Repository.Schema;

namespace Project.Scripts.Infra
{
    public class TestMasterDataFactory : IMasterDataFactory
    {
        public MasterData Create()
        {
            var masterData = new MasterData();
            masterData.TestSchema = new[]
            {
                new TestSchema() { Id = 1, Name = "Test1" }
            };
            
            return masterData;
        }
    }
}
