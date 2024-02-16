using AuctionsApp.Models;

namespace AuctionsApp.Data.Services.BidsServices
{
    public class BidService : IBidsService
    {
        private readonly ApplicationDbContext _context;

        public BidService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Bid bid)
        {
           _context.Bids.Add(bid);
        }
    }
}
