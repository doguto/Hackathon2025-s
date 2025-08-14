using System.IO;
using Cysharp.Threading.Tasks;
using MasterMemory;
using MessagePack;
using MessagePack.Resolvers;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Project.Scripts.Infra
{
    public class GameDatabaseLauncher
    {
        const string BinaryDirectoryPath = "Assets/Project/DataStore/Binary";

        const string MasterDataBinaryName = "MasterData.bytes";
        const string UserDataBinaryName = "UserData.bytes";
        
        string MasterDataBinaryPath => Path.Combine(BinaryDirectoryPath, MasterDataBinaryName);
        string UserDataBinaryPath => Path.Combine(BinaryDirectoryPath, UserDataBinaryName);
        
        public void Launch()
        {
            // MessagePackの初期化
            var messagePackResolvers = CompositeResolver.Create(
                MasterMemoryResolver.Instance,
                StandardResolver.Instance
            );
            var options = MessagePackSerializerOptions.Standard.WithResolver(messagePackResolvers);
            MessagePackSerializer.DefaultOptions = options;

            var masterDatabase = CreateMasterDatabase();
            var userDatabase = CreateUserDatabase();
            
            // GameDatabaseの初期化
            GameDatabase.SetDatabase(masterDatabase, userDatabase);
        }

        MemoryDatabase CreateMasterDatabase()
        {
            var masterBinaryAsset = Addressables.LoadAssetAsync<TextAsset>(MasterDataBinaryPath).WaitForCompletion();
            var masterBinary = masterBinaryAsset.bytes;
            return new MemoryDatabase(masterBinary);
        }

        MemoryDatabase CreateUserDatabase()
        {
            var userBinaryAsset = Addressables.LoadAssetAsync<TextAsset>(UserDataBinaryPath).WaitForCompletion();
            var userBinary = userBinaryAsset.bytes;
            return new MemoryDatabase(userBinary);
        }
    }
}
