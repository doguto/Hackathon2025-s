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
            
            // TODO: MasterDataの構築をクラスとして切り出す
            var masterData = new MasterData();
            masterData.TestSchema = new[]
            {
                new TestSchema() { Id = 1, Name = "Test1" }
            };
            
            generator.Generate(masterData);
        }
    }
}