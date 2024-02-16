using AuctionsApp.Models;

namespace AuctionsApp.Data.Services.ListingServices
{
    public interface IListingService
    {
        IQueryable<Listing> GetAllListing();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChanges();
    }
}
