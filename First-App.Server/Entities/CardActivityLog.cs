using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class CardActivityLog : BaseEntity
    {
        [Column("action")]
        public string? Action { get; set; }
        [Column("activity_time")]
        public DateTime ActivityTime { get; set; }
        [ForeignKey("card_id")]
        public int? CardId { get; set; }
        public Card Card { get; set; }
    }
}
