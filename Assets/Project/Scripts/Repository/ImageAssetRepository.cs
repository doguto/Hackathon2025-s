using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

namespace Project.Scripts.Repository
{
    public class ImageAssetRepository : AssetRepository<Image>
    {
        const string ImagePath = "Image";
        
        public async UniTask<Image> LoadImageAssetAsync(string imageName)
        {
            var assetPath = Path.Combine(ImagePath, imageName);
            return await LoadAddressableAsync(assetPath);
        }
    }
}
