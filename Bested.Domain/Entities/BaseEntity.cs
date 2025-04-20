// Bested.Domain\Entities\BaseEntity.cs
using System.ComponentModel.DataAnnotations;

namespace Bested.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime LastUpdatedAt {get; set;}
    }
}
