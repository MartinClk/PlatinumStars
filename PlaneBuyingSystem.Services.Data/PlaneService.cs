
namespace PlaneBuyingSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PlatinumStars.Data;
    using Interfaces;
    using PlatinumStars.Views.Home;

    public class PlaneService : IPlaneService
    {
        public readonly PlaneBuyingDbContext dbContext;

        public PlaneService(PlaneBuyingDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
            
        public async Task<IEnumerable<IndexViewModel>> LastThreePlanesAsync()
        {
            IEnumerable<IndexViewModel> lastThreePlanes = await this.dbContext
                .Planes
                .OrderByDescending(p => p.CreatedOn)
                .Take(3)
                .Select(p => new IndexViewModel 
                {
                    Id = p.Id.ToString(),
                    Title = p.Title,
                    ImageUrl = p.ImageUrl,
                })
                .ToArrayAsync();
            return lastThreePlanes;
        }
    }
}
