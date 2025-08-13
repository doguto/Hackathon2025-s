using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Project.Scripts.Repository
{
    public class AssetRepository<T>
    {
        const string TextureRootPath = "Assets/Textures";

        protected async UniTask<T> LoadAddressableAsync(string path)
        {
            var targetAssetPath = Path.Combine(TextureRootPath, path);
            var loadTask = Addressables.LoadAssetAsync<T>(targetAssetPath).Task;
            return await loadTask;
        }
    }
}
