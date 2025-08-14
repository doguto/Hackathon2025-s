using Project.Scripts.Repository.Schema;

namespace Project.Scripts.Infra
{
    public interface IMasterDataFactory
    {
        MasterData Create();
    }
}
