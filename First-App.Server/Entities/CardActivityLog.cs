namespace First_App.Server.Entities
{
    public class CardActivityLog : BaseEntity
    {
        public string? Action { get; set; }
        public DateTime ActivityTime { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
