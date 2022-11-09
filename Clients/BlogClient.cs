using System.Collections;
using PortfolioPage.DTOs;

namespace PortfolioPage.Clients;

public class BlogClient : IBlogClient
{
    private readonly HttpClient _httpClient;

    public BlogClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<PostDto>?> GetPostsFromBlog(int count)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PostDto>>($"{count}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        return null;
    }
}