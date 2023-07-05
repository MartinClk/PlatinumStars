
namespace PlaneBuyingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Category;
    public class Category
    {
        public Category() 
        {
            this.Planes = new HashSet<Plane>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Plane>  Planes { get; set; }

    }
}