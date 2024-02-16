using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionsApp.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public required string ImagePath { get; set; }
        public bool IsSold { get; set; } = false;

        public required string? IdentityUserId { get; set; }
        [ForeignKey(nameof(IdentityUserId))]
        public IdentityUser? User { get; set; }

        public List<Bid>? Bids { get; set; }
        public List<Comment>? Comments { get; set; }


    }
}
