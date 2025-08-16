using Project.Scripts.Repository;

namespace Project.Scripts.Model
{
    public class ModelBase
    {
        protected IDataRepository masterDataRepository = new MasterDataRepository();
        protected IDataRepository userDataRepository = new UserDataRepository();
    }
}
