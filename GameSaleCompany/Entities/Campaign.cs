using GameSaleCompany.Abstract;

namespace GameSaleCompany.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Percent { get; set; }
        public string Definition { get; set; }
        
    }
}
