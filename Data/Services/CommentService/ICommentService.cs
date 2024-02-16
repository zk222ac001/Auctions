using AuctionsApp.Models;

namespace AuctionsApp.Data.Services.CommentService
{
    public interface ICommentService
    {
        Task Add(Comment comment);
    }
}
