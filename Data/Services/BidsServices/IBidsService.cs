using AuctionsApp.Models;

namespace AuctionsApp.Data.Services.BidsServices
{
    public interface IBidsService
    {
        Task Add(Bid bid);
    }
}
