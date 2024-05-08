namespace First_App.Server.Entities
{
    public class Priority : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Card> Cards { get; set;}
    }
}
