using MasterMemory;
using MessagePack;
using MessagePack.Resolvers;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Project.Scripts.Infra
{
    public class GameDatabaseLauncher
    {
        const string BinaryDirectoryPath = "Assets/Project/DataStore/Binary";

        const string MasterDataBinaryName = "MasterData.bytes";
        const string UserDataBinaryName = "UserData.bytes";
        
        string MasterDataBinaryPath => $"{BinaryDirectoryPath}/{MasterDataBinaryName}";
        string UserDataBinaryPath => $"{BinaryDirectoryPath}/{UserDataBinaryName}";
        
        public void Launch()
        {
            // MessagePackの初期化
            var messagePackResolvers = CompositeResolver.Create(
                MasterMemoryResolver.Instance,
                StandardResolver.Instance
            );
            var options = MessagePackSerializerOptions.Standard.WithResolver(messagePackResolvers);
            MessagePackSerializer.DefaultOptions = options;

            var masterDatabase = CreateDatabase(MasterDataBinaryPath);
            var userDatabase = CreateDatabase(UserDataBinaryPath);
            
            // GameDatabaseの初期化
            GameDatabase.SetDatabase(masterDatabase, userDatabase);
        }

        MemoryDatabase CreateDatabase(string binaryPath)
        {
            var binaryAsset = Addressables.LoadAssetAsync<TextAsset>(binaryPath).WaitForCompletion();
            var binary = binaryAsset.bytes;
            return new MemoryDatabase(binary);
        }
    }
}
