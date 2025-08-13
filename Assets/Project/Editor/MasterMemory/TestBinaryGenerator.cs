
using System.IO;
using DG.Tweening.Plugins.Core.PathCore;
using MasterMemory;
using MessagePack;
using MessagePack.Resolvers;
using Project.Scripts.Repository.Schema;
using UnityEditor;
using Path = System.IO.Path;

namespace Project.Editor.MasterMemory
{
    public static class TestBinaryGenerator
    {
        [MenuItem("Tools/MasterMemory/GenerateBinaryTest")]
        static void Execute()
        {
            // MessagePackの初期化
            var messagePackResolver = CompositeResolver.Create(
                MasterMemoryResolver.Instance,
                StandardResolver.Instance
            );
            var options = MessagePackSerializerOptions.Standard.WithResolver(messagePackResolver);
            MessagePackSerializer.DefaultOptions = options;

            // 本来はCsv等からのインポート処理を記述
            var testData = new[]
            {
                new TestSchema(1, "Test1"),
                new TestSchema(2, "Test2"),
                new TestSchema(3, "Test3"),
                new TestSchema(4, "Test4"),
                new TestSchema(5, "Test5"),
            };

            DatabaseBuilder dataBuilder = new();
            dataBuilder.Append(testData);
            var binaryData = dataBuilder.Build();

            var path = "Assets/Project/DataStore/Binary/TestData.bytes";
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.WriteAllBytes(path, binaryData);
            AssetDatabase.Refresh();
        }
    }
}
