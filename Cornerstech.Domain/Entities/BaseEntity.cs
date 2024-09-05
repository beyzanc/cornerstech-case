using System.ComponentModel.DataAnnotations;

namespace Cornerstech.EntityLayer.Entities
{
    public abstract class BaseEntity // Base class containing common properties for all entities

    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
