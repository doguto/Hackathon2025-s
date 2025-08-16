using MasterMemory;
using Project.Scripts.Infra;

namespace Project.Scripts.Repository
{
    public class UserDataRepository : DataRepository
    {
        public override MemoryDatabase Database => GameDatabase.UserDatabase;
    }
}
