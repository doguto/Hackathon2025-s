using MasterMemory;

namespace Project.Scripts.Infra
{
    public static class GameDatabase
    {
        public static MemoryDatabase MasterDatabase { get; private set; }
        public static MemoryDatabase UserDatabase { get; private set; }

        public static void SetDatabase(MemoryDatabase masterDatabase, MemoryDatabase userDatabase)
        {
            MasterDatabase = masterDatabase;
            UserDatabase = userDatabase;
        }
    }
}