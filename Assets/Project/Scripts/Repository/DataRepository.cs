using MasterMemory;

namespace Project.Scripts.Repository
{
    public abstract class DataRepository
    {
        public abstract MemoryDatabase Database { get; }
    }   
}
