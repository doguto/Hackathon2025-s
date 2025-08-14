namespace Project.Scripts.Repository
{
    public abstract class DataRepository
    {
        protected const string DataStorePath = "Assets/Project/DataStore";
        protected const string BinaryDirectoryPath = "Assets/Project/DataStore/Binary";

        public abstract void Load();
    }   
}
