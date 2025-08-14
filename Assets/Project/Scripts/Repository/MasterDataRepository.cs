using System.IO;

namespace Project.Scripts.Repository
{
    public class MasterDataRepository : DataRepository
    {
        string masterDataPath = Path.Combine(DataStorePath, "MasterData");
        
        public override void Load()
        {
            
        }
    }
}