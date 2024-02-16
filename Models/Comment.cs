using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionsApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public required string? IdentityUserId { get; set; }
        [ForeignKey(nameof(IdentityUserId))]
        public IdentityUser? User { get; set; }

        public int? ListingId { get; set; }
        [ForeignKey(nameof(ListingId))]
        public Listing? Listing { get; set; }
    }
}