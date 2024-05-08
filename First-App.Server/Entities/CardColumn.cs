using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class CardColumn: BaseEntity
    {
        [Column("name")]
        public string? Name { get; set; }
        [ForeignKey("board_id")]
        public int BoardId { get; set; }
        public ICollection<Card> Cards { get; set;}
        public Board Boards { get; set;}
    }
}
