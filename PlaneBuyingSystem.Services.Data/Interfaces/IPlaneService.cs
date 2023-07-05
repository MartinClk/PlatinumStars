
namespace PlaneBuyingSystem.Services.Data.Interfaces
{
    using PlatinumStars.Views.Home;
    public interface IPlaneService
    {
        Task<IEnumerable<IndexViewModel>> LastThreePlanesAsync();
    }
}
