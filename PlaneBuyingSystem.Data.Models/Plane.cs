

namespace PlaneBuyingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Plane;
    public class Plane
    {
        public Plane() 
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLenght)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLenght)]
        public string ImageUrl { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

        [Required]
        public Guid AgentId { get; set; }

        public virtual Agent Agent { get; set; } = null!;

        public Guid? BuyerId { get; set; }

        public ApplicationUser? Buyer { get; set; }
    }
}
