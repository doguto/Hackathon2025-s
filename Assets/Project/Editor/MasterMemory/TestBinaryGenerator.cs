using System.IO;
using System.Linq;
using MasterMemory;
using MessagePack;
using MessagePack.Resolvers;
using Project.Scripts.Repository.Schema;
using UnityEditor;
using UnityEngine;

namespace Project.Editor.MasterMemory
{
    public static class TestBinaryGenerator
    {
        const string testDataPath = "Assets/Project/DataStore/TestData/Test.json";
        
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
            var streamReader = new StreamReader(testDataPath);
            var json = streamReader.ReadToEnd();
            streamReader.Close();

            var testData = JsonUtility.FromJson<TestData>(json);

            DatabaseBuilder dataBuilder = new();
            dataBuilder.Append(testData.tests.Select(x => x.ToSchema()));
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
