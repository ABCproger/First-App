using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class CardColumn: BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        public IQueryable<Card> Cards { get; set;}
    }
}
