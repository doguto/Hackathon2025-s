using MasterMemory;
using Project.Scripts.Infra;

namespace Project.Scripts.Repository
{
    public class IUserDataRepository : IDataRepository
    {
        public MemoryDatabase Database => GameDatabase.UserDatabase;
    }
}
