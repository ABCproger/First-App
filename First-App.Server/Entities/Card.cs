using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class Card : BaseEntity
    {
        [Column("name")]
        public string? Name { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("due_date")]
        public DateTime? DueDate { get; set; }
        [ForeignKey("card_column_id")]
        public int CardColumnId { get; set; }
        public int PriorityId { get; set; }
        public CardColumn CardColumn { get; set; }
        public Priority Priority { get; set; }
        public ICollection<CardActivityLog> CardActivityLogs { get; set; }
    }
}