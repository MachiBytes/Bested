// Bested.Domain\Entities\User.cs
namespace Bested.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string FirstName {get; set;}
        public string? MiddleName {get; set;}
        public required string LastName {get; set;}
        public string? Suffix {get; set;}
        public required string Email {get; set;}
        public required string HashedPassword {get; set;}
    }
}
