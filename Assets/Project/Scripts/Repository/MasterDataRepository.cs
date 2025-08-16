using MasterMemory;
using Project.Scripts.Infra;

namespace Project.Scripts.Repository
{
    public class MasterDataRepository : DataRepository
    {
        public override MemoryDatabase Database => GameDatabase.MasterDatabase;
    }
}
