using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class Priority : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        public ICollection<Card> Cards { get; set;}
    }
}
