using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
