
namespace PlaneBuyingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.agent;
    public class Agent
    {
        public Agent() 
        {
            this.Id = Guid.NewGuid();
            this.OwnedPlanes = new HashSet<Plane>();
        }  
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLenght)]      
        public string PhoneNumber { get; set; } = null!;

        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<Plane> OwnedPlanes { get; set; }
    }
}
