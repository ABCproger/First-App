using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.DataTransferObjects.Requests
{
    public class GetCardRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
