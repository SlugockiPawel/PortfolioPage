using PortfolioPage.DTOs;

namespace PortfolioPage.Clients;

public interface IBlogClient
{
    Task<IEnumerable<PostDto>?> GetPostsFromBlog(int count);
}