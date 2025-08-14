using Project.Scripts.Repository;
using UnityEditor;

namespace Project.Editor.MasterMemory
{
    public static class TestDataRepositoryTool
    {
        [MenuItem("Tools/MasterMemory/Test/TestDataRepository")]
        static void LoadData()
        {
            var testDataRepository = new TestDataRepository();
            testDataRepository.Load();
        }
    }
}
