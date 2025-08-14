using Project.Scripts.Infra;
using Project.Scripts.Repository.Schema;
using UnityEditor;

namespace Project.Editor.MasterMemory
{
    public static class BinaryGeneratorTool
    {
        [MenuItem("Tools/MasterMemory/GenerateMasterBinary")]
        static void GenerateMasterBinary()
        {
            var generator = new MasterBinaryGenerator();
            IMasterDataFactory factory = new TestMasterDataFactory();
            
            var masterData = factory.Create();
            generator.Generate(masterData);
        }
    }
}