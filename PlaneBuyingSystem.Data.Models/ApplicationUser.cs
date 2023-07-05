
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PlaneBuyingSystem.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser() 
        {
            this.Id = Guid.NewGuid();
            this.BoughtPlanes = new HashSet<Plane>();
        }
        public virtual ICollection<Plane> BoughtPlanes { get; set; }
    }

    
}
