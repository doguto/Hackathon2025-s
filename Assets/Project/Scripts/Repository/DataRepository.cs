using MasterMemory;

namespace Project.Scripts.Repository
{
    public interface IDataRepository
    {
        MemoryDatabase Database { get; }
    }   
}
