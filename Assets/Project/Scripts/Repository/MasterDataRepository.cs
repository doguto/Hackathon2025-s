using MasterMemory;
using Project.Scripts.Infra;

namespace Project.Scripts.Repository
{
    public class MasterDataRepository : IDataRepository
    {
        public MemoryDatabase Database => GameDatabase.MasterDatabase;
    }
}
