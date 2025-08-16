using MasterMemory;
using Project.Scripts.Infra;

namespace Project.Scripts.Repository
{
    public class UserDataRepository : IDataRepository
    {
        public MemoryDatabase Database => GameDatabase.UserDatabase;
    }
}
