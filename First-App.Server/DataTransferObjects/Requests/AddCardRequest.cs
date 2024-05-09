namespace First_App.Server.DataTransferObjects.Requests
{
    public class AddCardRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int? CardColumnId { get; set; }
        public int PriorityId { get; set; }
    }
}
