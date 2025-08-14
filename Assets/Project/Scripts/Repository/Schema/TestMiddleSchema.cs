namespace Project.Scripts.Repository.Schema
{
    [System.Serializable]
    public class TestMiddleSchema
    {
        public int id;
        public string name;

        public TestSchema ToSchema()
        {
            return new TestSchema { Id = id, Name = name };
        }
    }
}