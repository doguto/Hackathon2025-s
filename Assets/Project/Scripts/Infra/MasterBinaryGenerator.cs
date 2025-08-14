using Project.Scripts.Repository.Schema;

namespace Project.Scripts.Infra
{
    public class MasterBinaryGenerator : BinaryGenerator<MasterData>
    {
        protected override string DataName => "MasterData";

        public override void Generate(MasterData data)
        {
            var databaseBuilder = CreateMessagePack();
            
            // MasterDataの追加に伴い、ここにAppendしていく
            databaseBuilder.Append(data.TestSchema);
            
            WriteBinary(databaseBuilder);
        }
    }
}
