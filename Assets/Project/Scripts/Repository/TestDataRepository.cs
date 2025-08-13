using System.IO;
using MasterMemory;
using MessagePack;
using MessagePack.Resolvers;
using UnityEditor;
using UnityEngine;

namespace Project.Scripts.Repository
{
    public class TestDataRepository : DataRepository
    {
        public override void Load()
        {
            // MessagePackの初期化
            var messagePackResolvers = CompositeResolver.Create(
                MasterMemoryResolver.Instance,
                StandardResolver.Instance
            );
            var options = MessagePackSerializerOptions.Standard.WithResolver(messagePackResolvers);
            MessagePackSerializer.DefaultOptions = options;

            var fileName = "TestData.bytes";
            var path = Path.Combine(BinaryDirectoryPath, fileName);
            var asset = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
            var binary = asset.bytes;

            var memoryDatabase = new MemoryDatabase(binary);
            
            var testData = memoryDatabase.TestSchemaTable.FindById(2);
            Debug.Log(testData.Name);
        }
    }
}
