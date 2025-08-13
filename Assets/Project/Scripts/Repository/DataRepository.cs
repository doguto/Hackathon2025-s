namespace Project.Scripts.Repository
{
    public abstract class DataRepository
    {
        protected const string bynaryDirectoryPath = "Assets/Project/DataStore/Binary";

        public abstract void Load();
    }   
}
