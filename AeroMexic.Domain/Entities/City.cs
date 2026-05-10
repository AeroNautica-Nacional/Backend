
namespace AeroMexic.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int State_Id { get; set; }
        public State State { get; set; }
    }
}
