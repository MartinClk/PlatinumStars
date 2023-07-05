
namespace PlaneBuyingSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    using System.Threading;

    public class PlaneEntityConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder
                .Property(p => p.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);


            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Planes)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Agent)
                .WithMany(a => a.OwnedPlanes)
                .HasForeignKey(p => p.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

           builder.HasData(this.GeneretaPlanes());
        }

        private Plane[] GeneretaPlanes() 
        {
           ICollection<Plane> Planes = new HashSet<Plane>();
          
            Plane plane;
           
            plane = new Plane()
            {
            
                Title = "Airbus 787-8",
                Address = "Frankfurt Airport, Germany",
                Description = "The Boeing 787 is an American wide-body jet airliner developed and manufactured by Boeing Commercial Airplanes.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg/330px-All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg",
                Price = 60000000,
                CategoryId = 1,
                AgentId = Guid.Parse("F4069DA7-55DC-41E6-A80F-3B188AAA0D9F"),
                BuyerId = Guid.Parse("41039743-5044-4DDE-9F17-106A09DE88A2")               
            };
            Planes.Add(plane);

            plane = new Plane()
            {

               Title = "HondaJet Elite",
                Address = "Paris Airport, France",
                Description = "A continuation of the Elite program's vision to redefine the very light jet category with superior performance and efficiency born from aerodynamic breakthrough.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNonihuIe20wq6mDf5LHUWDsiQ4GCmYXZuaw&usqp=CAU",
                Price = 150000000,
                CategoryId = 2,
                AgentId = Guid.Parse("F4069DA7-55DC-41E6-A80F-3B188AAA0D9F")
            };
            Planes.Add(plane);

            plane = new Plane()
            {

                Title = "Antonov An-225-Mriya",
                Address = "Moscow Airport, Russia",
                Description = "A strategic airlift cargo aircraft designed and produced by the Antonov Design Bureau in the Soviet Union.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Antonov_An-225_Beltyukov-1.jpg/450px-Antonov_An-225_Beltyukov-1.jpg",
                Price = 700000000,
                CategoryId = 3,
                AgentId = Guid.Parse("F4069DA7-55DC-41E6-A80F-3B188AAA0D9F")
            };
            Planes.Add(plane);

            return Planes.ToArray();
        }
    }
}
