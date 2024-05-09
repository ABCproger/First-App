namespace First_App.Server.DataTransferObjects.Requests
{
    public class AddCardActivityLogDto
    {
        public string? Action { get; set; }
        public DateTime ActivityTime { get; set; }
        public int CardId { get; set; }
    }
}
