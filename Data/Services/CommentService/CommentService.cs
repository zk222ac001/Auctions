using AuctionsApp.Models;

namespace AuctionsApp.Data.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;
        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

      
    }
}
