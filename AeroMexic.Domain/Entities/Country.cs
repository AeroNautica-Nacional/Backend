
namespace AeroMexic.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClaveIso { get; set; }
        public int Moneda_Id { get; set; }
    }
}
