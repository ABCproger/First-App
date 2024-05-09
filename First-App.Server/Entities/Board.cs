using System.ComponentModel.DataAnnotations.Schema;

namespace First_App.Server.Entities
{
    public class Board : BaseEntity
    {
        [Column("name")]
        public string? Name { get; set; }

        public IQueryable<CardColumn> Columns { get; set; }
    }
}
