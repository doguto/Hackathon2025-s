using MasterMemory;
using MessagePack;

namespace Project.Scripts.Repository.Schema
{
    [MemoryTable("Test"), MessagePackObject(true)]
    public sealed class TestSchema
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
