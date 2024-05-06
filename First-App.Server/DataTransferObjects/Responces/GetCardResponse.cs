using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.DataTransferObjects.Responces
{
    public class GetCardResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int? CardColumnId { get; set; }
    }
}
